using System;


namespace Tween {


    public class IntervalChangedEventArgs : EventArgs {


        public IntervalChangedEventArgs(bool user_stream, bool timeline, bool reply, bool directmessage, bool public_search, bool lists, bool user_timeline) {
            this.UserStream = user_stream;
            this.Timeline = timeeline;
            this.Reply = reply;
            this.DirectMessage = directmessage;
            this.PublicSearch = public_search;
            this.Lists = lists;
            this.UserTimeline = user_timeline;
        }

        
        public bool UserStream {
            get { return this.user_stream_; }
            set { this.user_stream_ = value; }
        }


        public bool Timeline {
            get { return this.timeline_; }
            set { this.timeline_ = value; }
        }


        public bool Reply {
            get { return this.reply_; }
            set { this.reply_ = value; }
        }


        public bool DirectMessage {
            get { return this.direct_message_; }
            set { this.direct_message_ = value; }
        }


        public bool PublicSearch {
            get { return this.public_search_; }
            set { this.public_search_ = value; }
        }


        public bool Lists {
            get { return this.lists_; }
            set { this.lists_ = value; }
        }


        public bool UserTimeline {
            get { return this.user_timeline_; }
            set { this.user_timeline_ = value; }
        }


        private bool user_stream_;
        private bool timeline_;
        private bool direct_message_;
        private bool lists_;
        private bool user_timeline_;
    }

}
// Local Variables:
//   mode: ecmascript
//   coding: utf-8
// End:
