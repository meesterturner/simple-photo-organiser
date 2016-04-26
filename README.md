# simple-photo-organiser
Basic photo organiser application, primarily for my own use

## What it's for
I needed to organise my 18k+ photos on my personal laptop as they weren't in any particular order,
and for myself, a date-based organisational approach would be best.

This little tool will go through an existing folder structure, search for JPEGs, and attempt to
obtain the date the picture was taken using the Exif metadata. A new date-based structure will
be created, and the photos will be copied to the new structure.

## To-do
* If Exif date metadata doesn't exist, use the Windows file date, possibly as a checkbox option
* Option to move files rather than copy
