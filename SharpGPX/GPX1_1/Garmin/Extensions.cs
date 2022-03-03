namespace SharpGPX.GPX1_1.Garmin
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
        public static trkType SetExt(this trkType trk, TrackExtension ext)
        {
            if (trk == null) return null;
            if (trk.extensions == null)
                trk.extensions = new extensionsType();
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
        public static rteType SetExt(this rteType rte, RouteExtension ext)
        {
            if (rte == null) return null;
            if (rte.extensions == null)
                rte.extensions = new extensionsType();
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
        public static wptType SetExt<T>(this wptType wpt, T ext) where T : class, IPointExtension
        {
            if (wpt == null) return null;
            if (wpt.extensions == null)
                wpt.extensions = new extensionsType();
            wpt.extensions.Set<T>(ext);
            return wpt;
        }

        #endregion
    }
}
