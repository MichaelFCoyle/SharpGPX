﻿using SharpGPX.GPX1_1;
using SharpGPX.Properties;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using Utility;

namespace SharpGPX
{
    /// <summary>
    /// Read and write GPX files
    /// </summary>
    public class GpxClass 
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public GpxClass(GpxVersion version = GpxVersion.GPX_1_1) => GpxVersion = version;

        /// <summary>
        /// Create this class from the child class
        /// </summary>
        /// <param name="gpx"></param>
        GpxClass(gpxType gpx)
        {
            Creator = gpx.creator;
            Metadata = gpx.metadata;
            Extensions = gpx.extensions;
            Version = gpx.version;
            Waypoints = new wptTypeCollection(gpx.wpt);
            Tracks = new trkTypeCollection(gpx.trk);
            Routes = new rteTypeCollection(gpx.rte);
        }

        #region fields

        public GpxVersion GpxVersion { get; internal set; } = GpxVersion.GPX_1_1;

        public string Creator { get; set; }

        public metadataType Metadata { get; set; } = new metadataType();
        
        public extensionsType Extensions { get; set; }

        /// <summary> Version is set to "1.1" because this is part of the standards </summary>
        public string Version { get; } = "1.1";

        public wptTypeCollection Waypoints { get; set; } = new wptTypeCollection();

        public trkTypeCollection Tracks { get; set; } = new trkTypeCollection();

        public rteTypeCollection Routes { get; set; } = new rteTypeCollection();

        #endregion

        #region static methods

        /// <summary>
        /// Parse an XML string and return an object model that has the contents of the GPX file
        /// </summary>
        /// <param name="xmlString"></param>
        /// <returns></returns>
        public static GpxClass FromXml(string xmlString)
        {
            GpxVersion? version = GetVersion(xmlString);

            // if this isn't a GPX file the version will be null
            if (version == null)
                return new GpxClass();
            
            // if the version is 1.0 transform it to 1.1
            if (version == GpxVersion.GPX_1_0)
                xmlString = XsltHelper.Transform(xmlString, Resources.gpx10to11);

            // deserialize the xml and create the GpxClass
            return new GpxClass(Serializer.Deserialize<gpxType>(xmlString));
        }

        /// <summary>
        /// Load and parse the given GPX file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static GpxClass FromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
                return FromXml(reader.ReadToEnd());
        }

        /// <summary>
        /// Read Gpx from a stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static GpxClass FromStream(Stream stream)
        {
            using (StreamReader reader = new StreamReader(stream))
                return FromXml(reader.ReadToEnd());
        }

        /// <summary>
        /// Check the verion of the file and return true if it is 
        /// XML and is a version of this file we can read.
        /// </summary>
        /// <param name="xmlFileName">Path to a GPX file</param>
        /// <returns></returns>
        public static bool CheckFile(string xmlFileName)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFileName);

                return (doc.DocumentElement != null &&
                   (doc.DocumentElement.NamespaceURI == "http://www.topografix.com/GPX/1/0" ||
                     doc.DocumentElement.NamespaceURI == "http://www.topografix.com/GPX/1/1"));
            }
            catch (Exception ex)
            {
                Trace.TraceError("GpxClass.CheckFile: Error reading {0}: file is not xml:\r\n{1}", xmlFileName, ex);
                return false;
            }
        }

        /// <summary>
        /// Get the version of the xml string
        /// Return the version if it's a valid XML and valid GPX 
        /// Return null if it's not valid GPX 
        /// </summary>
        /// <param name="xmlString">XML</param>
        /// <returns></returns>
        public static GpxVersion? GetVersion(string xmlString)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlString);

                if (doc.DocumentElement == null)
                    return null;
                else if (doc.DocumentElement.NamespaceURI == "http://www.topografix.com/GPX/1/0")
                    return GpxVersion.GPX_1_0;
                else if (doc.DocumentElement.NamespaceURI == "http://www.topografix.com/GPX/1/1")
                    return GpxVersion.GPX_1_1;
                else
                    return null;
            }
            catch (Exception ex)
            {
                Trace.TraceError("GpxClass.GetVersion: Error: xml is not valid:\r\n{0}", ex);
                throw ex;
            }
        }

        #endregion

        #region internal methods

        /// <summary>
        /// Save as Gpx 1.1
        /// </summary>
        /// <returns></returns>
        internal gpxType ToGpx1_1()
        {
            var gpx1_1 = new gpxType()
            {
                creator = Creator,
                extensions = Extensions,
                metadata = Metadata,
                version = Version,
                rte = Routes == null ? new rteTypeCollection() : new rteTypeCollection(Routes),
                trk = Tracks == null ? new trkTypeCollection() : new trkTypeCollection(Tracks),
                wpt = Waypoints == null ? new wptTypeCollection() : new wptTypeCollection(Waypoints),
            };

            gpx1_1.Preserialize();
            return gpx1_1;
        }

        #endregion

        #region methods

        /// <summary>
        /// Save the GPX file to a string, using the given version
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public string ToXml(GpxVersion version)
        {
            string xmlString = Serializer.Serialize(ToGpx1_1());

            return (version == GpxVersion.GPX_1_0) ?
                XsltHelper.Transform(xmlString, Resources.gpx11to10) :
                xmlString;
        }

        /// <summary>
        /// Save the GPX file to a string with the most recent version
        /// </summary>
        /// <returns></returns>
        public string ToXml() => ToXml(GpxVersion.GPX_1_1);

        /// <summary>
        /// Save the GPX file to a stream
        /// </summary>
        /// <param name="stream"></param>
        public void ToStream(Stream stream) => ToStream(stream, GpxVersion.GPX_1_1);

        /// <summary>
        /// Save the GPX file to a stream in the given version
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="version"></param>
        private void ToStream(Stream stream, GpxVersion version)
        {
            if (version == GpxVersion.GPX_1_1)
                Serializer.Serialize(stream, ToGpx1_1());
            else
                XsltHelper.Transform(Serializer.Serialize(ToGpx1_1()), Resources.gpx11to10, stream);
        }

        /// <summary>
        /// write to a file
        /// </summary>
        /// <param name="fileName"></param>
        public void ToFile(string fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);

            using (FileStream stream = File.OpenWrite(fileName))
                ToStream(stream, GpxVersion.GPX_1_1);
        }

        /// <summary>
        /// Get a boundsType that represents the bounds of this data
        /// </summary>
        /// <returns></returns>
        public boundsType GetBounds()
        {
            boundsType bounds = new boundsType();
            bounds = Tracks.GetBounds().Union(bounds);
            bounds = Routes.GetBounds().Union(bounds);
            bounds = Waypoints.GetBounds().Union(bounds);
            return bounds;
        }

        /// <summary>
        /// Count all elements and sub elements
        /// </summary>
        /// <returns></returns>
        public int CountElements()
        {
            int count = Waypoints.Count + Routes.Count + Tracks.Count;

            if (Routes != null)
                count += Routes.Sum(x => x.rtept.Count);

            if (Tracks != null)
                count += Tracks.Sum(x => x.trkseg.Sum(y => y.trkpt.Count));

            return count;
        }

        #endregion
    }
}
