using SharpGPX.GPX1_1;
using System.Linq;

namespace SharpGPX
{
    public static class Extensions
    {
        /// <summary>
        /// Get a deserialized element if it exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>(this GPX1_1.extensionsType ext) where T : class
        {
            if (ext.Any == null || ext.Any.Count() == 0) return null;

            foreach (var element in ext.Any)
            {
                try
                {
                    T item = Utility.Serializer.Deserialize<T>(element);
                    if (item != null)
                        return item;
                }
                catch { }
            }
            return null;
        }

        public static GPX1_1.Garmin.TrackExtension_t GetGarminExt(this trkType trk) => trk.extensions.Get<GPX1_1.Garmin.TrackExtension_t>();
        public static GPX1_1.Topografix.GpxStyle.lineType GetTopografixLine(this trkType trk) => trk.extensions.Get<GPX1_1.Topografix.GpxStyle.lineType>();

    }
}
