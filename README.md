# SharpGpx

## Project Description

SharpGpx implements an object model for reading and writing GPX ([GPS eXchange](http://en.wikipedia.org/wiki/GPS_eXchange_Format)). An extremely common format, GPX is used to record data and exchange data from GPS units.

This is the .NET Standard version of this library. See [here for the previous, .NET Framework version](https://github.com/BlueToque/SharpGpx-1-0)

## Details

The library is developed under .NET Standard and has no external dependencies.

The library makes extensive use of [XML Serialization](http://msdn.microsoft.com/en-us/library/ms950721.aspx). Extremely large files may fail to save or load.

## Development

This library made use of a code generator based on the _xsd.exe_ utility. The generator reads in an [XML Schema Document (XSD)](http://en.wikipedia.org/wiki/XML_schema) and generates C# classes from the schema. You shouldn't need to edit the GPX XSDs. If you do, you're basically tampering with the [GPX standard](http://www.topografix.com/gpx.asp).
