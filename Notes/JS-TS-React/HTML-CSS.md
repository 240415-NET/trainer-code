# HTML and CSS Study Guide

## HTML

### HTML Semantic Tags

- Semantic tags provide meaning to the content, making it more understandable for both developers and search engines.
- Examples of semantic tags include `<article>`, `<section>`, `<header>`, `<footer>`, and `<nav>`.

### HTML5 Doctype Declaration

- The HTML5 doctype declaration is `<!DOCTYPE html>`.
- It tells the browser that the document is an HTML5 document.

### HTML as a Programming Language

- HTML is not a programming language; it is a markup language used for structuring content on the web.

### Tags within the `<body>` Element

- The `<body>` element contains all the contents of an HTML document, such as text, images, videos, links, tables, and other elements.

### Input Tag's Type Attribute

- The `type` attribute for an input tag specifies the type of input element to display.
- Valid values include: `text`, `password`, `email`, `number`, `date`, `checkbox`, `radio`, `file`, `submit`, etc.

### Non-HTML5 Tags

- In HTML5, certain tags from previous versions are no longer used.
- Examples of tags not used in HTML5 include: `<font>`, `<center>`, `<big>`, `<strike>`, and `<frame>`.

### Inline Elements

- Inline elements do not start on a new line and only take up as much width as necessary.
- Examples include: `<span>`, `<a>`, `<img>`, `<strong>`, `<em>`.

## CSS

### CSS Units

- CSS units define the measurement of elements' sizes, margins, paddings, etc.
- Common CSS units include: `px` (pixels), `em` (relative to the font-size of the element), `rem` (relative to the font-size of the root element), `%` (percentage), `vh` (viewport height), `vw` (viewport width).
- An invalid unit example would be: `pts` (not valid in CSS).

### CSS Box Model

- The CSS Box Model consists of several components from the outermost to the innermost:
  1. **Margin**: Clears an area outside the border. It is transparent.
  2. **Border**: A border surrounding the padding (if any) and content.
  3. **Padding**: Clears an area around the content. It is transparent.
  4. **Content**: The actual content, such as text, images, or other media.

### Internal Style Sheet

- To define an internal style sheet, use the `<style>` tag within the `<head>` section of an HTML document.
- Example:

  ```html
  <head>
    <style>
      body {
        background-color: lightblue;
      }
    </style>
  </head>
  ```

### External Style Sheet

- An external style sheet is used to define styles for multiple pages of a website.
- It is linked to an HTML document using the `<link>` tag within the `<head>` section.
- Example:

  ```html
  <head>
    <link rel="stylesheet" type="text/css" href="styles.css">
  </head>
  ```

- The `href` attribute specifies the path to the CSS file.
- The CSS file (e.g., `styles.css`) can contain all the styling rules:

  ```css
  body {
    background-color: lightblue;
  }
  h1 {
    color: navy;
    margin-left: 20px;
  }
  ```
