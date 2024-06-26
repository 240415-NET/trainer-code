# Normalization Notes

## functional dependency X -> Y (Y dependent on X)

- "Y is a fact about X"
- between sets of columns (including 1 -> 1).
- By definition of the meaning of the data (business logic), for each possible set of X values, there's
  exactly one possible set of Y values.
- if there were two rows with all the same X, you know for sure their Y must also be the same. the reverse
  may not be true!

## candidate key for a table

- minimal set of columns that every other column is dependent on.
- if i have a set of columns everything else depends on, and i can't remove any from my set without breaking that, then this is a candidate key.
- this means the values of any of the candidate keys can uniquely identify each row.
- often these are just one column (if it's more than one column, we can call it a composite key).

## when we implement a table we choose one of the candidate keys to be what we call the primary key

- this will for practical purposes identify that row uniquely for us.
- this is the one that other tables will reference as a foreign key.
- for many simpler data models, there will often just be one candidate key.

## normalization

- process of reducing redundancy, improve referential integrity, to read/write with consistency
- remove insertion, update, and deletion anomalies.
  - update anomaly: redundant info is updated in some rows but not all.
  - deletion anomaly: if we delete a row representing some info, we may be deleting other data without realizing it.
  - insertion anomaly: counterpart to deletion anomaly. if we don't have rows for certain data, - we cannot represent other data at all.
  - reduce the need to completely restructure if the data model changes

## There are 6 normal forms, 1-3 are the practical ones

### first normal form

- all elements are atomic values, not lists/groups/sets. break them up to more rows adding new columns just to split up groups (e.g. Course1, Course2)
- each row must be unique (so there must be some candidate keys - we choose one, and call it the primary key)

### second normal form -

- all columns which are not part of any candidate key, cannot have partial dependency on any of the candidate keys
  - that is, they all have to be fully dependent on every candidate key
        if there are no composite keys, 1NF implies 2NF.

### third normal form -

- no non-CK column can depend on any other non-CK column.
  - transitive dependency: an indirect dependency. if A -> B, and B -> C, then transitive dep from A to C
- "the keys, the whole keys, and nothing but the keys"
  - "the key" - every non-CK column must depend on every CK --- that's the definition of a CK, so this is saying, "a CK must exist"
  - "the whole key" - every non-CK column must depend on the whole of every CK, not just part
  - "nothing but the key" - every non-CK column must depend non-transitively on every CK.

## referential integrity

- every foreign key value actually points to something in another table.
