

namespace Tween.Mime {


    /**
     * 
     */
    public class ContentType {
        /**
         * 
         */
        private ContentType(string type, string sub_type)
            : this(type, sub_type, string.Empty) {
        }
        /**
         * 
         */
        private ContentType(string type, string sub_type, string parameter) {
            this.type_ = type;
            this.sub_type_ = sub_type;
            this.parameter_ = parameter;
        }

        
        /**
         * 
         */
        public string Type {
            get { return this.type_; }
        }


        /**
         * 
         */
        public string SubType {
            get { return this.sub_type_; }
        }


        /**
         * 
         */
        public string Parameter {
            get { return this.parameter_; }
            set { this.parameter_ = value; }
        }


        /**
         * 
         */
        public override string ToString() {
            if ( this.Parameter == string.Empty )
                return string.Format( "{0}/{1}", this.Type, this.SubType );
            
            return string.Format( "{0}/{1}; {3}", this.Type, this.SubType, this.Parameter );
        }


        /**
         * 
         */
        public static ContentType ValueOf(string extension) {
            extension = extension.ToLower();
            switch ( extension ) {
            case ".jpg": goto case ".jpeg";
            case ".jpe": goto case ".jpeg";
            case ".jpeg":
                return new ContentType( "image", "jpeg" );

            case ".gif":
                return new ContentType( "image", "gif" );

            case ".png":
                return new ContentType(  "image", "png" );

            case ".tif": goto case ".tiff";
            case ".tiff":
                return new ContentType( "image", "tiff" );

            case ".bmp":
                return new ContentType( "image", "x-bmp" );

            case ".avi":
                return new ContentType( "video", "avi" );

            case ".wmv":
                return new ContentType( "video", "x-ms-wmv" );

            case ".flv":
                return new ContentType( "video", "x-flv" );

            case ".m4v":
                return new ContentType( "video", "x-m4v" );

            case ".mov":
                return new ContentType( "video", "quicktime" );

            case ".mp4":
                return new ContentType( "video", "3gpp" );

            case ".rm":
                return new ContentType( "application", "vnd.rn-realmedia" );

            case ".mpg": goto case ".mpeg";
            case ".mpeg":
                return new ContentType( "video", "mpeg" );

            case ".3gp":
                return new ContentType( "movie", "3gp" );

            case ".3g2":
                return new ContentType( "video", "3gpp2" );

            default:
                return new ContentType( "application", "octet-stream" );
            }
        }

        
        private string type_;
        private string sub_type_;
        private string parameter_;
    }


}
// Local Variables:
//   coding: utf-8
//   mode: ecmascript-mode
// End:
