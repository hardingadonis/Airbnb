/*
! tailwindcss v3.3.3 | MIT License | https://tailwindcss.com
*/

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: #e5e7eb;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
5. Use the user's configured `sans` font-feature-settings by default.
6. Use the user's configured `sans` font-variation-settings by default.
*/

html {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  /* 3 */
  tab-size: 4;
  /* 3 */
  font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
  -webkit-font-feature-settings: normal;
          font-feature-settings: normal;
  /* 5 */
  font-variation-settings: normal;
  /* 6 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  -webkit-font-feature-settings: inherit;
          font-feature-settings: inherit;
  /* 1 */
  font-variation-settings: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  font-weight: inherit;
  /* 1 */
  line-height: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Reset default styling for dialogs.
*/

dialog {
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-webkit-input-placeholder, textarea::-webkit-input-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */

[hidden] {
  display: none;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::-webkit-backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

.container {
  width: 100%;
}

@media (min-width: 550px) {
  .container {
    max-width: 550px;
  }
}

@media (min-width: 640px) {
  .container {
    max-width: 640px;
  }
}

@media (min-width: 745px) {
  .container {
    max-width: 745px;
  }
}

@media (min-width: 768px) {
  .container {
    max-width: 768px;
  }
}

@media (min-width: 950px) {
  .container {
    max-width: 950px;
  }
}

@media (min-width: 1024px) {
  .container {
    max-width: 1024px;
  }
}

@media (min-width: 1130px) {
  .container {
    max-width: 1130px;
  }
}

@media (min-width: 1280px) {
  .container {
    max-width: 1280px;
  }
}

@media (min-width: 1440px) {
  .container {
    max-width: 1440px;
  }
}

@media (min-width: 1536px) {
  .container {
    max-width: 1536px;
  }
}

.pointer-events-none {
  pointer-events: none;
}

.pointer-events-auto {
  pointer-events: auto;
}

.visible {
  visibility: visible;
}

.collapse {
  visibility: collapse;
}

.static {
  position: static;
}

.fixed {
  position: fixed;
}

.absolute {
  position: absolute;
}

.relative {
  position: relative;
}

.sticky {
  position: -webkit-sticky;
  position: sticky;
}

.-left-12 {
  left: -3rem;
}

.-left-24 {
  left: -6rem;
}

.-left-6 {
  left: -1.5rem;
}

.-right-24 {
  right: -6rem;
}

.-top-16 {
  top: -4rem;
}

.-top-20 {
  top: -5rem;
}

.bottom-0 {
  bottom: 0px;
}

.bottom-10 {
  bottom: 2.5rem;
}

.bottom-2 {
  bottom: 0.5rem;
}

.bottom-20 {
  bottom: 5rem;
}

.bottom-c13 {
  bottom: 13px;
}

.-left-12 {
  left: -3rem;
}

.-left-24 {
  left: -6rem;
}

.left-0 {
  left: 0px;
}

.left-1 {
  left: 0.25rem;
}

.left-10 {
  left: 2.5rem;
}

.left-16 {
  left: 4rem;
}

.left-2 {
  left: 0.5rem;
}

.left-24 {
  left: 6rem;
}

.left-4 {
  left: 1rem;
}

.left-6 {
  left: 1.5rem;
}

.left-c12 {
  left: 12px;
}

.left-c16 {
  left: 16px;
}

.left-c20 {
  left: 20px;
}

.left-c29 {
  left: 29px;
}

.left-c32 {
  left: 32px;
}

.left-c75 {
  left: 75px;
}

.left-c8 {
  left: 8px;
}

.-right-24 {
  right: -6rem;
}

.right-0 {
  right: 0px;
}

.right-6 {
  right: 1.5rem;
}

.right-c8 {
  right: 8px;
}

.-top-16 {
  top: -4rem;
}

.top-0 {
  top: 0px;
}

.top-1 {
  top: 0.25rem;
}

.top-10 {
  top: 2.5rem;
}

.top-14 {
  top: 3.5rem;
}

.top-16 {
  top: 4rem;
}

.top-2 {
  top: 0.5rem;
}

.top-20 {
  top: 5rem;
}

.top-6 {
  top: 1.5rem;
}

.top-7 {
  top: 1.75rem;
}

.top-8 {
  top: 2rem;
}

.top-c-2 {
  top: -2px;
}

.top-c-3 {
  top: -3px;
}

.top-c26 {
  top: 26px;
}

.z-0 {
  z-index: 0;
}

.z-10 {
  z-index: 10;
}

.z-20 {
  z-index: 20;
}

.m-0 {
  margin: 0px;
}

.m-1 {
  margin: 0.25rem;
}

.m-10 {
  margin: 2.5rem;
}

.m-c2 {
  margin: 2px;
}

.m-c4 {
  margin: 4px;
}

.m-c64 {
  margin: 64px;
}

.m-c7 {
  margin: 7px;
}

.mx-c5 {
  margin-left: 5px;
  margin-right: 5px;
}

.mx-c6 {
  margin-left: 6px;
  margin-right: 6px;
}

.my-2 {
  margin-top: 0.5rem;
  margin-bottom: 0.5rem;
}

.my-5 {
  margin-top: 1.25rem;
  margin-bottom: 1.25rem;
}

.my-6 {
  margin-top: 1.5rem;
  margin-bottom: 1.5rem;
}

.my-8 {
  margin-top: 2rem;
  margin-bottom: 2rem;
}

.my-c10 {
  margin-top: 10px;
  margin-bottom: 10px;
}

.-ml-3 {
  margin-left: -3px;
}

.-mt-3 {
  margin-top: -3px;
}

.-mt-5 {
  margin-top: -1.25rem;
}

.mb-0 {
  margin-bottom: 0px;
}

.mb-10 {
  margin-bottom: 2.5rem;
}

.mb-11 {
  margin-bottom: 2.75rem;
}

.mb-12 {
  margin-bottom: 3rem;
}

.mb-2 {
  margin-bottom: 0.5rem;
}

.mb-20 {
  margin-bottom: 5rem;
}

.mb-4 {
  margin-bottom: 1rem;
}

.mb-5 {
  margin-bottom: 1.25rem;
}

.mb-6 {
  margin-bottom: 1.5rem;
}

.mb-8 {
  margin-bottom: 2rem;
}

.mb-9 {
  margin-bottom: 2.25rem;
}

.mb-c-2 {
  margin-bottom: -2px;
}

.mb-c-3 {
  margin-bottom: -3px;
}

.mb-c-4 {
  margin-bottom: -4px;
}

.mb-c10 {
  margin-bottom: 10px;
}

.mb-c12 {
  margin-bottom: 12px;
}

.mb-c13 {
  margin-bottom: 13px;
}

.mb-c14 {
  margin-bottom: 14px;
}

.mb-c2 {
  margin-bottom: 2px;
}

.mb-c20 {
  margin-bottom: 20px;
}

.mb-c24 {
  margin-bottom: 24px;
}

.mb-c28 {
  margin-bottom: 28px;
}

.mb-c30 {
  margin-bottom: 30px;
}

.mb-c4 {
  margin-bottom: 4px;
}

.mb-c54 {
  margin-bottom: 54px;
}

.mb-c6 {
  margin-bottom: 6px;
}

.-ml-3 {
  margin-left: -3px;
}

.ml-2 {
  margin-left: 0.5rem;
}

.ml-3 {
  margin-left: 3px;
}

.ml-4 {
  margin-left: 1rem;
}

.ml-48 {
  margin-left: 12rem;
}

.ml-6 {
  margin-left: 1.5rem;
}

.ml-8 {
  margin-left: 2rem;
}

.ml-c2 {
  margin-left: 2px;
}

.ml-c4 {
  margin-left: 4px;
}

.mr-10 {
  margin-right: 2.5rem;
}

.mr-12 {
  margin-right: 3rem;
}

.mr-2 {
  margin-right: 0.5rem;
}

.mr-20 {
  margin-right: 5rem;
}

.mr-3 {
  margin-right: 3px;
}

.mr-6 {
  margin-right: 1.5rem;
}

.mr-7 {
  margin-right: 1.75rem;
}

.mr-c12 {
  margin-right: 12px;
}

.mr-c2 {
  margin-right: 2px;
}

.mr-c4 {
  margin-right: 4px;
}

.mr-c6 {
  margin-right: 6px;
}

.-mt-3 {
  margin-top: -3px;
}

.-mt-5 {
  margin-top: -1.25rem;
}

.mt-0 {
  margin-top: 0px;
}

.mt-1 {
  margin-top: 0.25rem;
}

.mt-10 {
  margin-top: 2.5rem;
}

.mt-14 {
  margin-top: 3.5rem;
}

.mt-16 {
  margin-top: 4rem;
}

.mt-2 {
  margin-top: 0.5rem;
}

.mt-20 {
  margin-top: 5rem;
}

.mt-24 {
  margin-top: 6rem;
}

.mt-4 {
  margin-top: 1rem;
}

.mt-6 {
  margin-top: 1.5rem;
}

.mt-7 {
  margin-top: 1.75rem;
}

.mt-8 {
  margin-top: 2rem;
}

.mt-c-12 {
  margin-top: -12px;
}

.mt-c1 {
  margin-top: 1px;
}

.mt-c10 {
  margin-top: 10px;
}

.mt-c12 {
  margin-top: 12px;
}

.mt-c14 {
  margin-top: 14px;
}

.mt-c15 {
  margin-top: 15px;
}

.mt-c16 {
  margin-top: 16px;
}

.mt-c2 {
  margin-top: 2px;
}

.mt-c20 {
  margin-top: 20px;
}

.mt-c26 {
  margin-top: 26px;
}

.mt-c4 {
  margin-top: 4px;
}

.mt-c5 {
  margin-top: 5px;
}

.mt-c6 {
  margin-top: 6px;
}

.mt-c7 {
  margin-top: 7px;
}

.box-border {
  box-sizing: border-box;
}

.box-content {
  box-sizing: content-box;
}

.block {
  display: block;
}

.inline-block {
  display: inline-block;
}

.inline {
  display: inline;
}

.flex {
  display: flex;
}

.inline-flex {
  display: inline-flex;
}

.table {
  display: table;
}

.grid {
  display: grid;
}

.contents {
  display: contents;
}

.hidden {
  display: none;
}

.aspect-square {
  aspect-ratio: 1 / 1;
}

.h-0 {
  height: 0px;
}

.h-10 {
  height: 2.5rem;
}

.h-12 {
  height: 3rem;
}

.h-14 {
  height: 3.5rem;
}

.h-16 {
  height: 4rem;
}

.h-2 {
  height: 0.5rem;
}

.h-20 {
  height: 5rem;
}

.h-24 {
  height: 6rem;
}

.h-28 {
  height: 7rem;
}

.h-3 {
  height: 3px;
}

.h-40 {
  height: 10rem;
}

.h-48 {
  height: 12rem;
}

.h-5 {
  height: 1.25rem;
}

.h-52 {
  height: 13rem;
}

.h-6 {
  height: 1.5rem;
}

.h-60 {
  height: 15rem;
}

.h-7 {
  height: 1.75rem;
}

.h-8 {
  height: 2rem;
}

.h-9 {
  height: 2.25rem;
}

.h-auto {
  height: auto;
}

.h-c1 {
  height: 1px;
}

.h-c100 {
  height: 100px;
}

.h-c106 {
  height: 106px;
}

.h-c112 {
  height: 112px;
}

.h-c122 {
  height: 122px;
}

.h-c14 {
  height: 14px;
}

.h-c16 {
  height: 16px;
}

.h-c20 {
  height: 20px;
}

.h-c200 {
  height: 200px;
}

.h-c24 {
  height: 24px;
}

.h-c32 {
  height: 32px;
}

.h-c388 {
  height: 388px;
}

.h-c40 {
  height: 40px;
}

.h-c42 {
  height: 42px;
}

.h-c56 {
  height: 56px;
}

.h-c568 {
  height: 568px;
}

.h-c6 {
  height: 6px;
}

.h-c60 {
  height: 60px;
}

.h-c70 {
  height: 70px;
}

.h-c72 {
  height: 72px;
}

.h-full {
  height: 100%;
}

.h-screen {
  height: 100vh;
}

.max-h-full {
  max-height: 100%;
}

.min-h-full {
  min-height: 100%;
}

.w-0 {
  width: 0px;
}

.w-1 {
  width: 0.25rem;
}

.w-1\/5 {
  width: 20%;
}

.w-10 {
  width: 2.5rem;
}

.w-12 {
  width: 3rem;
}

.w-14 {
  width: 3.5rem;
}

.w-16 {
  width: 4rem;
}

.w-2 {
  width: 0.5rem;
}

.w-20 {
  width: 5rem;
}

.w-24 {
  width: 6rem;
}

.w-28 {
  width: 7rem;
}

.w-3 {
  width: 3px;
}

.w-32 {
  width: 8rem;
}

.w-40 {
  width: 10rem;
}

.w-48 {
  width: 12rem;
}

.w-5 {
  width: 1.25rem;
}

.w-56 {
  width: 14rem;
}

.w-6 {
  width: 1.5rem;
}

.w-60 {
  width: 15rem;
}

.w-7 {
  width: 1.75rem;
}

.w-72 {
  width: 18rem;
}

.w-8 {
  width: 2rem;
}

.w-80 {
  width: 20rem;
}

.w-9 {
  width: 2.25rem;
}

.w-96 {
  width: 24rem;
}

.w-auto {
  width: auto;
}

.w-c1 {
  width: 1px;
}

.w-c118 {
  width: 118px;
}

.w-c122 {
  width: 122px;
}

.w-c14 {
  width: 14px;
}

.w-c183 {
  width: 183px;
}

.w-c20 {
  width: 20px;
}

.w-c32 {
  width: 32px;
}

.w-c568 {
  width: 568px;
}

.w-c6 {
  width: 6px;
}

.w-c77 {
  width: 77px;
}

.w-c82 {
  width: 82px;
}

.w-c9 {
  width: 9px;
}

.w-c92 {
  width: 92px;
}

.w-full {
  width: 100%;
}

.w-screen {
  width: 100vw;
}

.min-w-full {
  min-width: 100%;
}

.max-w-c568 {
  max-width: 568px;
}

.max-w-full {
  max-width: 100%;
}

.max-w-xs {
  max-width: 20rem;
}

.flex-1 {
  flex: 1 1 0%;
}

.flex-shrink {
  flex-shrink: 1;
}

.shrink-0 {
  flex-shrink: 0;
}

.border-collapse {
  border-collapse: collapse;
}

.transform {
  -webkit-transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
          transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.cursor-pointer {
  cursor: pointer;
}

.resize {
  resize: both;
}

.snap-y {
  scroll-snap-type: y var(--tw-scroll-snap-strictness);
}

.snap-start {
  scroll-snap-align: start;
}

.list-decimal {
  list-style-type: decimal;
}

.list-disc {
  list-style-type: disc;
}

.grid-flow-row {
  grid-auto-flow: row;
}

.grid-cols-1 {
  grid-template-columns: repeat(1, minmax(0, 1fr));
}

.grid-cols-2 {
  grid-template-columns: repeat(2, minmax(0, 1fr));
}

.grid-cols-3 {
  grid-template-columns: repeat(3, minmax(0, 1fr));
}

.grid-cols-4 {
  grid-template-columns: repeat(4, minmax(0, 1fr));
}

.grid-cols-6 {
  grid-template-columns: repeat(6, minmax(0, 1fr));
}

.grid-rows-1 {
  grid-template-rows: repeat(1, minmax(0, 1fr));
}

.flex-row {
  flex-direction: row;
}

.flex-col {
  flex-direction: column;
}

.flex-wrap {
  flex-wrap: wrap;
}

.flex-nowrap {
  flex-wrap: nowrap;
}

.items-start {
  align-items: flex-start;
}

.items-end {
  align-items: flex-end;
}

.items-center {
  align-items: center;
}

.justify-start {
  justify-content: flex-start;
}

.justify-end {
  justify-content: flex-end;
}

.justify-center {
  justify-content: center;
}

.justify-between {
  justify-content: space-between;
}

.justify-around {
  justify-content: space-around;
}

.justify-items-end {
  justify-items: end;
}

.gap-1 {
  gap: 0.25rem;
}

.gap-10 {
  gap: 2.5rem;
}

.gap-11 {
  gap: 2.75rem;
}

.gap-2 {
  gap: 0.5rem;
}

.gap-3 {
  gap: 3px;
}

.gap-4 {
  gap: 1rem;
}

.gap-5 {
  gap: 1.25rem;
}

.gap-6 {
  gap: 1.5rem;
}

.gap-7 {
  gap: 1.75rem;
}

.gap-8 {
  gap: 2rem;
}

.gap-9 {
  gap: 2.25rem;
}

.gap-c10 {
  gap: 10px;
}

.gap-c12 {
  gap: 12px;
}

.gap-c14 {
  gap: 14px;
}

.gap-c16 {
  gap: 16px;
}

.gap-c18 {
  gap: 18px;
}

.gap-c2 {
  gap: 2px;
}

.gap-c20 {
  gap: 20px;
}

.gap-c29 {
  gap: 29px;
}

.gap-c4 {
  gap: 4px;
}

.gap-c5 {
  gap: 5px;
}

.gap-c6 {
  gap: 6px;
}

.gap-c9 {
  gap: 9px;
}

.gap-x-2 {
  -webkit-column-gap: 0.5rem;
          column-gap: 0.5rem;
}

.gap-x-6 {
  -webkit-column-gap: 1.5rem;
          column-gap: 1.5rem;
}

.gap-x-c10 {
  -webkit-column-gap: 10px;
          column-gap: 10px;
}

.gap-x-c12 {
  -webkit-column-gap: 12px;
          column-gap: 12px;
}

.gap-x-c48 {
  -webkit-column-gap: 48px;
          column-gap: 48px;
}

.gap-y-24 {
  row-gap: 6rem;
}

.gap-y-3 {
  row-gap: 3px;
}

.gap-y-6 {
  row-gap: 1.5rem;
}

.gap-y-c12 {
  row-gap: 12px;
}

.gap-y-c30 {
  row-gap: 30px;
}

.gap-y-c48 {
  row-gap: 48px;
}

.justify-self-end {
  justify-self: end;
}

.overflow-auto {
  overflow: auto;
}

.overflow-hidden {
  overflow: hidden;
}

.overflow-visible {
  overflow: visible;
}

.overflow-scroll {
  overflow: scroll;
}

.overflow-x-hidden {
  overflow-x: hidden;
}

.overflow-y-hidden {
  overflow-y: hidden;
}

.overflow-x-scroll {
  overflow-x: scroll;
}

.overflow-y-scroll {
  overflow-y: scroll;
}

.whitespace-nowrap {
  white-space: nowrap;
}

.rounded {
  border-radius: 0.25rem;
}

.rounded-2xl {
  border-radius: 1rem;
}

.rounded-3xl {
  border-radius: 1.5rem;
}

.rounded-c070 {
  border-radius: 0.70rem;
}

.rounded-c073 {
  border-radius: 0.73rem;
}

.rounded-c077 {
  border-radius: 0.77rem;
}

.rounded-full {
  border-radius: 9999px;
}

.rounded-lg {
  border-radius: 0.5rem;
}

.rounded-md {
  border-radius: 0.375rem;
}

.rounded-sm {
  border-radius: 0.125rem;
}

.rounded-xl {
  border-radius: 0.75rem;
}

.rounded-b-lg {
  border-bottom-right-radius: 0.5rem;
  border-bottom-left-radius: 0.5rem;
}

.rounded-b-md {
  border-bottom-right-radius: 0.375rem;
  border-bottom-left-radius: 0.375rem;
}

.rounded-r-2xl {
  border-top-right-radius: 1rem;
  border-bottom-right-radius: 1rem;
}

.rounded-r-xl {
  border-top-right-radius: 0.75rem;
  border-bottom-right-radius: 0.75rem;
}

.rounded-t-2xl {
  border-top-left-radius: 1rem;
  border-top-right-radius: 1rem;
}

.rounded-t-3xl {
  border-top-left-radius: 1.5rem;
  border-top-right-radius: 1.5rem;
}

.rounded-t-lg {
  border-top-left-radius: 0.5rem;
  border-top-right-radius: 0.5rem;
}

.rounded-t-md {
  border-top-left-radius: 0.375rem;
  border-top-right-radius: 0.375rem;
}

.rounded-t-xl {
  border-top-left-radius: 0.75rem;
  border-top-right-radius: 0.75rem;
}

.rounded-tr-lg {
  border-top-right-radius: 0.5rem;
}

.rounded-tr-xl {
  border-top-right-radius: 0.75rem;
}

.border {
  border-width: 1px;
}

.border-0 {
  border-width: 0px;
}

.border-2 {
  border-width: 2px;
}

.border-4 {
  border-width: 4px;
}

.border-c1 {
  border-width: 1px;
}

.border-c2 {
  border-width: 2px;
}

.border-y-2 {
  border-top-width: 2px;
  border-bottom-width: 2px;
}

.border-b {
  border-bottom-width: 1px;
}

.border-b-2 {
  border-bottom-width: 2px;
}

.border-b-c1 {
  border-bottom-width: 1px;
}

.border-l {
  border-left-width: 1px;
}

.border-l-c1 {
  border-left-width: 1px;
}

.border-r {
  border-right-width: 1px;
}

.border-r-2 {
  border-right-width: 2px;
}

.border-r-4 {
  border-right-width: 4px;
}

.border-r-c1 {
  border-right-width: 1px;
}

.border-t {
  border-top-width: 1px;
}

.border-t-c1 {
  border-top-width: 1px;
}

.border-solid {
  border-style: solid;
}

.border-black {
  --tw-border-opacity: 1;
  border-color: rgb(0 0 0 / var(--tw-border-opacity));
}

.border-black222 {
  --tw-border-opacity: 1;
  border-color: rgb(34 34 34 / var(--tw-border-opacity));
}

.border-blue-400 {
  --tw-border-opacity: 1;
  border-color: rgb(96 165 250 / var(--tw-border-opacity));
}

.border-gray-200 {
  --tw-border-opacity: 1;
  border-color: rgb(229 231 235 / var(--tw-border-opacity));
}

.border-gray-300 {
  --tw-border-opacity: 1;
  border-color: rgb(209 213 219 / var(--tw-border-opacity));
}

.border-gray-400 {
  --tw-border-opacity: 1;
  border-color: rgb(156 163 175 / var(--tw-border-opacity));
}

.border-gray-500 {
  --tw-border-opacity: 1;
  border-color: rgb(107 114 128 / var(--tw-border-opacity));
}

.border-gray-600 {
  --tw-border-opacity: 1;
  border-color: rgb(75 85 99 / var(--tw-border-opacity));
}

.border-gray-700 {
  --tw-border-opacity: 1;
  border-color: rgb(55 65 81 / var(--tw-border-opacity));
}

.border-gray7 {
  --tw-border-opacity: 1;
  border-color: rgb(113 113 113 / var(--tw-border-opacity));
}

.border-indigo-600 {
  --tw-border-opacity: 1;
  border-color: rgb(79 70 229 / var(--tw-border-opacity));
}

.border-lgray {
  --tw-border-opacity: 1;
  border-color: rgb(235 235 235 / var(--tw-border-opacity));
}

.border-lgray2 {
  --tw-border-opacity: 1;
  border-color: rgb(247 247 247 / var(--tw-border-opacity));
}

.border-lgrayd {
  --tw-border-opacity: 1;
  border-color: rgb(221 221 221 / var(--tw-border-opacity));
}

.border-mdgray {
  --tw-border-opacity: 1;
  border-color: rgb(176 176 176 / var(--tw-border-opacity));
}

.border-red-200 {
  --tw-border-opacity: 1;
  border-color: rgb(254 202 202 / var(--tw-border-opacity));
}

.border-red-400 {
  --tw-border-opacity: 1;
  border-color: rgb(248 113 113 / var(--tw-border-opacity));
}

.border-red-500 {
  --tw-border-opacity: 1;
  border-color: rgb(239 68 68 / var(--tw-border-opacity));
}

.border-red-600 {
  --tw-border-opacity: 1;
  border-color: rgb(220 38 38 / var(--tw-border-opacity));
}

.border-red-700 {
  --tw-border-opacity: 1;
  border-color: rgb(185 28 28 / var(--tw-border-opacity));
}

.border-red-900 {
  --tw-border-opacity: 1;
  border-color: rgb(127 29 29 / var(--tw-border-opacity));
}

.border-transparent {
  border-color: transparent;
}

.border-white {
  --tw-border-opacity: 1;
  border-color: rgb(255 255 255 / var(--tw-border-opacity));
}

.border-yellow-400 {
  --tw-border-opacity: 1;
  border-color: rgb(250 204 21 / var(--tw-border-opacity));
}

.border-yellow-900 {
  --tw-border-opacity: 1;
  border-color: rgb(113 63 18 / var(--tw-border-opacity));
}

.bg-black {
  --tw-bg-opacity: 1;
  background-color: rgb(0 0 0 / var(--tw-bg-opacity));
}

.bg-black\/50 {
  background-color: rgb(0 0 0 / 0.5);
}

.bg-blue-300 {
  --tw-bg-opacity: 1;
  background-color: rgb(147 197 253 / var(--tw-bg-opacity));
}

.bg-blue-400 {
  --tw-bg-opacity: 1;
  background-color: rgb(96 165 250 / var(--tw-bg-opacity));
}

.bg-blue-500 {
  --tw-bg-opacity: 1;
  background-color: rgb(59 130 246 / var(--tw-bg-opacity));
}

.bg-blue-600 {
  --tw-bg-opacity: 1;
  background-color: rgb(37 99 235 / var(--tw-bg-opacity));
}

.bg-gray-300 {
  --tw-bg-opacity: 1;
  background-color: rgb(209 213 219 / var(--tw-bg-opacity));
}

.bg-gray-unknown {
  --tw-bg-opacity: 1;
  background-color: rgb(190 181 170 / var(--tw-bg-opacity));
}

.bg-lgray {
  --tw-bg-opacity: 1;
  background-color: rgb(235 235 235 / var(--tw-bg-opacity));
}

.bg-lgray2 {
  --tw-bg-opacity: 1;
  background-color: rgb(247 247 247 / var(--tw-bg-opacity));
}

.bg-lgrayd {
  --tw-bg-opacity: 1;
  background-color: rgb(221 221 221 / var(--tw-bg-opacity));
}

.bg-mgray {
  --tw-bg-opacity: 1;
  background-color: rgb(176 176 176 / var(--tw-bg-opacity));
}

.bg-red-500 {
  --tw-bg-opacity: 1;
  background-color: rgb(239 68 68 / var(--tw-bg-opacity));
}

.bg-red-600 {
  --tw-bg-opacity: 1;
  background-color: rgb(220 38 38 / var(--tw-bg-opacity));
}

.bg-red-900 {
  --tw-bg-opacity: 1;
  background-color: rgb(127 29 29 / var(--tw-bg-opacity));
}

.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.bg-yellow-500 {
  --tw-bg-opacity: 1;
  background-color: rgb(234 179 8 / var(--tw-bg-opacity));
}

.object-contain {
  object-fit: contain;
}

.object-cover {
  object-fit: cover;
}

.object-scale-down {
  object-fit: scale-down;
}

.p-1 {
  padding: 0.25rem;
}

.p-3 {
  padding: 3px;
}

.p-4 {
  padding: 1rem;
}

.p-6 {
  padding: 1.5rem;
}

.p-8 {
  padding: 2rem;
}

.p-c10 {
  padding: 10px;
}

.p-c14 {
  padding: 14px;
}

.p-c2 {
  padding: 2px;
}

.p-c3 {
  padding: 3px;
}

.p-c32 {
  padding: 32px;
}

.p-c4 {
  padding: 4px;
}

.p-c5 {
  padding: 5px;
}

.px-1 {
  padding-left: 0.25rem;
  padding-right: 0.25rem;
}

.px-10 {
  padding-left: 2.5rem;
  padding-right: 2.5rem;
}

.px-2 {
  padding-left: 0.5rem;
  padding-right: 0.5rem;
}

.px-20 {
  padding-left: 5rem;
  padding-right: 5rem;
}

.px-24 {
  padding-left: 6rem;
  padding-right: 6rem;
}

.px-4 {
  padding-left: 1rem;
  padding-right: 1rem;
}

.px-40 {
  padding-left: 10rem;
  padding-right: 10rem;
}

.px-5 {
  padding-left: 1.25rem;
  padding-right: 1.25rem;
}

.px-6 {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}

.px-8 {
  padding-left: 2rem;
  padding-right: 2rem;
}

.px-80 {
  padding-left: 20rem;
  padding-right: 20rem;
}

.px-c10 {
  padding-left: 10px;
  padding-right: 10px;
}

.px-c12 {
  padding-left: 12px;
  padding-right: 12px;
}

.px-c14 {
  padding-left: 14px;
  padding-right: 14px;
}

.px-c16 {
  padding-left: 16px;
  padding-right: 16px;
}

.px-c18 {
  padding-left: 18px;
  padding-right: 18px;
}

.px-c20 {
  padding-left: 20px;
  padding-right: 20px;
}

.px-c24 {
  padding-left: 24px;
  padding-right: 24px;
}

.px-c32 {
  padding-left: 32px;
  padding-right: 32px;
}

.py-12 {
  padding-top: 3rem;
  padding-bottom: 3rem;
}

.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.py-4 {
  padding-top: 1rem;
  padding-bottom: 1rem;
}

.py-5 {
  padding-top: 1.25rem;
  padding-bottom: 1.25rem;
}

.py-6 {
  padding-top: 1.5rem;
  padding-bottom: 1.5rem;
}

.py-7 {
  padding-top: 1.75rem;
  padding-bottom: 1.75rem;
}

.py-8 {
  padding-top: 2rem;
  padding-bottom: 2rem;
}

.py-c12 {
  padding-top: 12px;
  padding-bottom: 12px;
}

.py-c14 {
  padding-top: 14px;
  padding-bottom: 14px;
}

.py-c16 {
  padding-top: 16px;
  padding-bottom: 16px;
}

.py-c18 {
  padding-top: 18px;
  padding-bottom: 18px;
}

.py-c24 {
  padding-top: 24px;
  padding-bottom: 24px;
}

.py-c7 {
  padding-top: 7px;
  padding-bottom: 7px;
}

.pb-0 {
  padding-bottom: 0px;
}

.pb-1 {
  padding-bottom: 0.25rem;
}

.pb-10 {
  padding-bottom: 2.5rem;
}

.pb-12 {
  padding-bottom: 3rem;
}

.pb-14 {
  padding-bottom: 3.5rem;
}

.pb-16 {
  padding-bottom: 4rem;
}

.pb-2 {
  padding-bottom: 0.5rem;
}

.pb-20 {
  padding-bottom: 5rem;
}

.pb-6 {
  padding-bottom: 1.5rem;
}

.pb-8 {
  padding-bottom: 2rem;
}

.pb-c10 {
  padding-bottom: 10px;
}

.pb-c11 {
  padding-bottom: 11px;
}

.pb-c12 {
  padding-bottom: 12px;
}

.pb-c14 {
  padding-bottom: 14px;
}

.pb-c16 {
  padding-bottom: 16px;
}

.pb-c2 {
  padding-bottom: 2px;
}

.pb-c20 {
  padding-bottom: 20px;
}

.pb-c4 {
  padding-bottom: 4px;
}

.pb-c72 {
  padding-bottom: 72px;
}

.pl-0 {
  padding-left: 0px;
}

.pl-10 {
  padding-left: 2.5rem;
}

.pl-12 {
  padding-left: 3rem;
}

.pl-20 {
  padding-left: 5rem;
}

.pl-3 {
  padding-left: 3px;
}

.pl-4 {
  padding-left: 1rem;
}

.pl-6 {
  padding-left: 1.5rem;
}

.pl-8 {
  padding-left: 2rem;
}

.pl-c12 {
  padding-left: 12px;
}

.pl-c13 {
  padding-left: 13px;
}

.pl-c2 {
  padding-left: 2px;
}

.pl-c20 {
  padding-left: 20px;
}

.pl-c22 {
  padding-left: 22px;
}

.pr-10 {
  padding-right: 2.5rem;
}

.pr-2 {
  padding-right: 0.5rem;
}

.pr-24 {
  padding-right: 6rem;
}

.pr-6 {
  padding-right: 1.5rem;
}

.pr-8 {
  padding-right: 2rem;
}

.pr-c18 {
  padding-right: 18px;
}

.pr-c20 {
  padding-right: 20px;
}

.pr-c4 {
  padding-right: 4px;
}

.pt-0 {
  padding-top: 0px;
}

.pt-10 {
  padding-top: 2.5rem;
}

.pt-12 {
  padding-top: 3rem;
}

.pt-14 {
  padding-top: 3.5rem;
}

.pt-2 {
  padding-top: 0.5rem;
}

.pt-3 {
  padding-top: 3px;
}

.pt-4 {
  padding-top: 1rem;
}

.pt-5 {
  padding-top: 1.25rem;
}

.pt-6 {
  padding-top: 1.5rem;
}

.pt-7 {
  padding-top: 1.75rem;
}

.pt-8 {
  padding-top: 2rem;
}

.pt-c11 {
  padding-top: 11px;
}

.pt-c12 {
  padding-top: 12px;
}

.pt-c15 {
  padding-top: 15px;
}

.pt-c18 {
  padding-top: 18px;
}

.pt-c20 {
  padding-top: 20px;
}

.pt-c25 {
  padding-top: 25px;
}

.pt-c3 {
  padding-top: 3px;
}

.pt-c4 {
  padding-top: 4px;
}

.pt-c7 {
  padding-top: 7px;
}

.text-left {
  text-align: left;
}

.text-center {
  text-align: center;
}

.text-right {
  text-align: right;
}

.text-3xl {
  font-size: 1.875rem;
  line-height: 2.25rem;
}

.text-9xl {
  font-size: 8rem;
  line-height: 1;
}

.text-base {
  font-size: 1rem;
  line-height: 1.5rem;
}

.text-c10 {
  font-size: 10px;
}

.text-c12 {
  font-size: 12px;
}

.text-c14 {
  font-size: 14px;
}

.text-c15 {
  font-size: 15px;
}

.text-c16 {
  font-size: 16px;
}

.text-c18 {
  font-size: 18px;
}

.text-c22 {
  font-size: 22px;
}

.text-c32 {
  font-size: 32px;
}

.text-sm {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.text-xs {
  font-size: 0.75rem;
  line-height: 1rem;
}

.font-black {
  font-weight: 900;
}

.font-bold {
  font-weight: 700;
}

.font-extrabold {
  font-weight: 800;
}

.font-light {
  font-weight: 300;
}

.font-medium {
  font-weight: 500;
}

.font-normal {
  font-weight: 400;
}

.font-semibold {
  font-weight: 600;
}

.font-thin {
  font-weight: 100;
}

.leading-3 {
  line-height: .75rem;
}

.leading-4 {
  line-height: 1rem;
}

.leading-5 {
  line-height: 1.25rem;
}

.leading-6 {
  line-height: 1.5rem;
}

.leading-7 {
  line-height: 1.75rem;
}

.leading-8 {
  line-height: 2rem;
}

.leading-c1 {
  line-height: 1px;
}

.leading-c10 {
  line-height: 10px;
}

.leading-c16 {
  line-height: 16px;
}

.leading-c25 {
  line-height: 25px;
}

.leading-c6 {
  line-height: 6px;
}

.leading-loose {
  line-height: 2;
}

.leading-normal {
  line-height: 1.5;
}

.leading-snug {
  line-height: 1.375;
}

.leading-tight {
  line-height: 1.25;
}

.tracking-wide {
  letter-spacing: 0.025em;
}

.text-black {
  --tw-text-opacity: 1;
  color: rgb(0 0 0 / var(--tw-text-opacity));
}

.text-black222 {
  --tw-text-opacity: 1;
  color: rgb(34 34 34 / var(--tw-text-opacity));
}

.text-blue-500 {
  --tw-text-opacity: 1;
  color: rgb(59 130 246 / var(--tw-text-opacity));
}

.text-blue-600 {
  --tw-text-opacity: 1;
  color: rgb(37 99 235 / var(--tw-text-opacity));
}

.text-blue-700 {
  --tw-text-opacity: 1;
  color: rgb(29 78 216 / var(--tw-text-opacity));
}

.text-gray-300 {
  --tw-text-opacity: 1;
  color: rgb(209 213 219 / var(--tw-text-opacity));
}

.text-gray-400 {
  --tw-text-opacity: 1;
  color: rgb(156 163 175 / var(--tw-text-opacity));
}

.text-gray-500 {
  --tw-text-opacity: 1;
  color: rgb(107 114 128 / var(--tw-text-opacity));
}

.text-gray-600 {
  --tw-text-opacity: 1;
  color: rgb(75 85 99 / var(--tw-text-opacity));
}

.text-gray-700 {
  --tw-text-opacity: 1;
  color: rgb(55 65 81 / var(--tw-text-opacity));
}

.text-gray-800 {
  --tw-text-opacity: 1;
  color: rgb(31 41 55 / var(--tw-text-opacity));
}

.text-gray-900 {
  --tw-text-opacity: 1;
  color: rgb(17 24 39 / var(--tw-text-opacity));
}

.text-gray7 {
  --tw-text-opacity: 1;
  color: rgb(113 113 113 / var(--tw-text-opacity));
}

.text-red-700 {
  --tw-text-opacity: 1;
  color: rgb(185 28 28 / var(--tw-text-opacity));
}

.text-red-900 {
  --tw-text-opacity: 1;
  color: rgb(127 29 29 / var(--tw-text-opacity));
}

.text-transparent {
  color: transparent;
}

.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.underline {
  text-decoration-line: underline;
}

.underline-offset-1 {
  text-underline-offset: 1px;
}

.caret-blue-900 {
  caret-color: #1e3a8a;
}

.caret-red-900 {
  caret-color: #7f1d1d;
}

.opacity-0 {
  opacity: 0;
}

.opacity-10 {
  opacity: 0.1;
}

.opacity-100 {
  opacity: 1;
}

.opacity-20 {
  opacity: 0.2;
}

.opacity-30 {
  opacity: 0.3;
}

.opacity-5 {
  opacity: 0.05;
}

.opacity-50 {
  opacity: 0.5;
}

.opacity-60 {
  opacity: 0.6;
}

.opacity-70 {
  opacity: 0.7;
}

.opacity-75 {
  opacity: 0.75;
}

.opacity-80 {
  opacity: 0.8;
}

.opacity-90 {
  opacity: 0.9;
}

.shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-2xl {
  --tw-shadow: 0 25px 50px -12px rgb(0 0 0 / 0.25);
  --tw-shadow-colored: 0 25px 50px -12px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-inner {
  --tw-shadow: inset 0 2px 4px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: inset 0 2px 4px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-lg {
  --tw-shadow: 0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 10px 15px -3px var(--tw-shadow-color), 0 4px 6px -4px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-md {
  --tw-shadow: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 4px 6px -1px var(--tw-shadow-color), 0 2px 4px -2px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-none {
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-sm {
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.outline {
  outline-style: solid;
}

.outline-offset-2 {
  outline-offset: 2px;
}

.outline-black222 {
  outline-color: #222222;
}

.outline-gray-700 {
  outline-color: #374151;
}

.brightness-50 {
  --tw-brightness: brightness(.5);
  -webkit-filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
          filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.contrast-200 {
  --tw-contrast: contrast(2);
  -webkit-filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
          filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow {
  --tw-drop-shadow: drop-shadow(0 1px 2px rgb(0 0 0 / 0.1)) drop-shadow(0 1px 1px rgb(0 0 0 / 0.06));
  -webkit-filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
          filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow-2xl {
  --tw-drop-shadow: drop-shadow(0 25px 25px rgb(0 0 0 / 0.15));
  -webkit-filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
          filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.filter {
  -webkit-filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
          filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.backdrop-filter {
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
          backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.transition {
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, -webkit-transform, -webkit-filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-transform, -webkit-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.transition-all {
  transition-property: all;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.ease-linear {
  transition-timing-function: linear;
}

.ease-out {
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
}

.placeholder\:text-sm::-webkit-input-placeholder {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.placeholder\:text-sm::placeholder {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.placeholder\:text-gray-600::-webkit-input-placeholder {
  --tw-text-opacity: 1;
  color: rgb(75 85 99 / var(--tw-text-opacity));
}

.placeholder\:text-gray-600::placeholder {
  --tw-text-opacity: 1;
  color: rgb(75 85 99 / var(--tw-text-opacity));
}

.after\:absolute::after {
  content: var(--tw-content);
  position: absolute;
}

.after\:top-c43::after {
  content: var(--tw-content);
  top: 43px;
}

.after\:h-c2::after {
  content: var(--tw-content);
  height: 2px;
}

.hover\:bg-black:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(0 0 0 / var(--tw-bg-opacity));
}

.hover\:bg-white:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.focus\:outline-none:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.focus\:outline-0:focus {
  outline-width: 0px;
}

@media (min-width: 550px) {
  .\35\:flex {
    display: flex;
  }
}

@media (min-width: 745px) {
  .\37\:static {
    position: static;
  }

  .\37\:mt-20 {
    margin-top: 5rem;
  }

  .\37\:mt-c20 {
    margin-top: 20px;
  }

  .\37\:block {
    display: block;
  }

  .\37\:flex {
    display: flex;
  }

  .\37\:hidden {
    display: none;
  }

  .\37\:h-20 {
    height: 5rem;
  }

  .\37\:h-c16 {
    height: 16px;
  }

  .\37\:h-c388 {
    height: 388px;
  }

  .\37\:w-c568 {
    width: 568px;
  }

  .\37\:w-c82 {
    width: 82px;
  }

  .\37\:w-full {
    width: 100%;
  }

  .\37\:grid-cols-2 {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .\37\:grid-cols-3 {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .\37\:gap-10 {
    gap: 2.5rem;
  }

  .\37\:gap-y-6 {
    row-gap: 1.5rem;
  }

  .\37\:rounded-2xl {
    border-radius: 1rem;
  }

  .\37\:rounded-c070 {
    border-radius: 0.70rem;
  }

  .\37\:border-c1 {
    border-width: 1px;
  }

  .\37\:border-lgrayd {
    --tw-border-opacity: 1;
    border-color: rgb(221 221 221 / var(--tw-border-opacity));
  }

  .\37\:p-c5 {
    padding: 5px;
  }

  .\37\:px-10 {
    padding-left: 2.5rem;
    padding-right: 2.5rem;
  }

  .\37\:px-c32 {
    padding-left: 32px;
    padding-right: 32px;
  }

  .\37\:py-4 {
    padding-top: 1rem;
    padding-bottom: 1rem;
  }

  .\37\:pb-10 {
    padding-bottom: 2.5rem;
  }

  .\37\:pb-c14 {
    padding-bottom: 14px;
  }

  .\37\:pl-0 {
    padding-left: 0px;
  }

  .\37\:pl-10 {
    padding-left: 2.5rem;
  }

  .\37\:pr-10 {
    padding-right: 2.5rem;
  }

  .\37\:pt-c18 {
    padding-top: 18px;
  }

  .\37\:opacity-0 {
    opacity: 0;
  }

  .\37\:opacity-100 {
    opacity: 1;
  }
}

@media (min-width: 950px) {
  .\39\:flex {
    display: flex;
  }

  .\39\:hidden {
    display: none;
  }

  .\39\:grid-cols-3 {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .\39\:justify-center {
    justify-content: center;
  }

  .\39\:text-center {
    text-align: center;
  }
}

@media (min-width: 1130px) {
  .\31 1\:block {
    display: block;
  }

  .\31 1\:flex {
    display: flex;
  }

  .\31 1\:grid {
    display: grid;
  }

  .\31 1\:hidden {
    display: none;
  }

  .\31 1\:grid-cols-4 {
    grid-template-columns: repeat(4, minmax(0, 1fr));
  }

  .\31 1\:grid-cols-6 {
    grid-template-columns: repeat(6, minmax(0, 1fr));
  }

  .\31 1\:justify-between {
    justify-content: space-between;
  }

  .\31 1\:gap-y-c30 {
    row-gap: 30px;
  }

  .\31 1\:px-20 {
    padding-left: 5rem;
    padding-right: 5rem;
  }

  .\31 1\:pb-0 {
    padding-bottom: 0px;
  }

  .\31 1\:pb-10 {
    padding-bottom: 2.5rem;
  }

  .\31 1\:pt-4 {
    padding-top: 1rem;
  }
}

@media (min-width: 1440px) {
  .\31 4\:px-20 {
    padding-left: 5rem;
    padding-right: 5rem;
  }
}