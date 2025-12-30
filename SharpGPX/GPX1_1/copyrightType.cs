namespace SharpGPX.GPX1_1
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "Xml Serialization Name")]
    public partial class copyrightType
    {
        public copyrightType() { }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public copyrightType(copyrightType other)
        {
            author = other.author;
            license = other.license;
            year = other.year;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="author"></param>
        /// <param name="year"></param>
        /// <param name="license"></param>
        public copyrightType(string author, string year = "", string license = "")
        {
            this.author = author;
            this.license = license;
            this.year = year;
        }

        internal void Preserialize()
        {
            if (author.IsNullOrEmpty()) author = null;

            if (license.IsNullOrEmpty()) license = null;

            if (year.IsNullOrEmpty()) year = null;
        }
    }

}
