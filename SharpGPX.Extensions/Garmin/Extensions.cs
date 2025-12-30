using SharpGPX.GPX1_1;
using System.Drawing;

namespace SharpGPX.Extensions.Garmin
{
    public static class Extensions
    {
        #region Garmin extensions

        /// <summary>
        /// Get a Garmin Track Extension from a GPX track
        /// </summary>
        /// <param name="trk"></param>
        /// <returns></returns>
        public static TrackExtension GetExt(this trkType trk) => trk.extensions.Get<TrackExtension>();

        /// <summary>
        /// Set a Garmin Track Extension
        /// </summary>
        /// <param name="trk"></param>
        /// <param name="ext"></param>
        public static trkType? SetExt(this trkType trk, TrackExtension ext)
        {
            if (trk == null) 
                return null;
            trk.extensions ??= new extensionsType();
            trk.extensions.Set(ext);
            return trk;
        }

        /// <summary>
        /// Get a Garmin Route Extension from a GPX route
        /// </summary>
        /// <param name="rte"></param>
        /// <returns></returns>
        public static RouteExtension GetExt(this rteType rte) => rte.extensions.Get<RouteExtension>();

        /// <summary>
        /// Set a Garmin Track Extension
        /// </summary>
        /// <param name="trk"></param>
        /// <param name="ext"></param>
        public static rteType? SetExt(this rteType rte, RouteExtension ext)
        {
            if (rte == null) 
                return null;
            rte.extensions ??= new extensionsType();
            rte.extensions.Set(ext);
            return rte;
        }

        /// <summary>
        /// Get either a Garmin Route Point Extension or a Garmin Waypoint Extension
        /// </summary>
        /// <param name="wpts"></param>
        /// <returns></returns>
        public static T GetExt<T>(this wptType wpt) where T : class => wpt.extensions.Get<T>();

        /// <summary>
        /// Set either a Garmin Route Point Extension or a Garmin Waypoint Extension
        /// </summary>
        /// <param name="wpts"></param>
        /// <returns></returns>
        public static wptType? SetExt<T>(this wptType wpt, T ext) where T : class//, IPointExtension
        {
            if (wpt == null) 
                return null;
            wpt.extensions ??= new extensionsType();
            wpt.extensions.Set<T>(ext);
            return wpt;
        }

        #endregion

        public static Color ToWindowsColor(this DisplayColor_t color) => 
            color switch
            {
                DisplayColor_t.Black => Color.Black,
                DisplayColor_t.DarkRed => Color.DarkRed,
                DisplayColor_t.DarkGreen => Color.DarkGreen,
                DisplayColor_t.DarkYellow => Color.Yellow,
                DisplayColor_t.DarkBlue => Color.DarkBlue,
                DisplayColor_t.DarkMagenta => Color.DarkMagenta,
                DisplayColor_t.DarkCyan => Color.DarkCyan,
                DisplayColor_t.LightGray => Color.LightGray,
                DisplayColor_t.DarkGray => Color.DarkGray,
                DisplayColor_t.Red => Color.Red,
                DisplayColor_t.Green => Color.Green,
                DisplayColor_t.Yellow => Color.Yellow,
                DisplayColor_t.Blue => Color.Blue,
                DisplayColor_t.Magenta => Color.Magenta,
                DisplayColor_t.Cyan => Color.Cyan,
                DisplayColor_t.White => Color.White,
                DisplayColor_t.Transparent => Color.Transparent,
                _ => Color.Black,
            };
        
    }
}
