# simple-photo-organiser
This is a basic photo organiser application.

## What it's for
I needed to organise my 18k+ photos on my personal laptop as they weren't in any particular order,
and for myself, a date-based organisational approach would be best.

This little tool will go through an existing folder structure, search for JPEGs, and attempt to
obtain the date the picture was taken using the Exif metadata. A new date-based structure will
be created, and the photos will be copied to the new structure.

Any images where the date was unable to be obtained will be copied into a default "Unknown" folder.

## Development
This project is being developed using Visual Studio 2015