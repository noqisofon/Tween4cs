//  
//  WorkerResult.cs
//  
//  Author:
//       rihine <ned.rihine@gmail.com>
// 
//  Copyright (c) 2011 rihine All rights reserved.
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
using System;
using System.Collections.Generic;
using System.Drawing;

using Tween.Common;


namespace Tween.Widgets {


    /**
     * 
     */
    internal class WorkerResult {
        /**
         *
         */
        public WorkerResult() {
            this.result_message_ = string.Empty;
            this.start_page_ = 0;
            this.end_page_ = 0;
            this.worker_type_ = WorkerType.Timeline;
            this.images_ = new Dictionary<string, Image>();
            this.tab_name_ = string.Empty;
            this.ids_ = new List<long>();
            this.success_ids_ = new List<long>();
            this.new_direct_message_ = false;
            this.addtion_count_ = 0;
            this.status_ = new PostingStatus();
        }


        /**
         *
         */
        public string ResultMessage {
            get { return this.result_message_; }
            set { this.result_message_ = value; }
        }
        


        /**
         *
         */
        public int StartPage {
            get { return this.start_page_; }
            set { this.start_page_ = value; }
        }
        

        /**
         *
         */
        public int EndPage {
            get { return this.end_page_; }
            set { this.end_page_ = value; }
        }
        

        /**
         *
         */
        public WorkerType WorkerType {
            get { return this.worker_type_; }
            set { this.worker_type_ = value; }
        }
        

        /**
         *
         */
        public IDictionary<string, Image> Images {
            get { return this.images_; }
        }
        

        /**
         *
         */
        public string TabName {
            get { return this.tab_name_; }
            protected set { this.tab_name_ = value; }
        }


        /**
         *
         */
        public IList<long> Ids {
            get { return this.ids_; }
        }


        /**
         *
         */
        public IList<long> SuccessIds {
            get { return this.success_ids_; }
        }
        

        /**
         *
         */
        public bool NewDM {
            get { return this.new_direct_message_; }
            protected set { this.new_direct_message_ = value; }
        }
        

        /**
         *
         */
        public int AddtionCount {
            get { return this.addtion_count_; }
            protected set { this.addtion_count_ = value; }
        }
        

        /**
         *
         */
        public  PostingStatus Status {
            get { return this.status_; }
            protected set { this.status_ = value; }
        }


        private string result_message_;
        private int start_page_;
        private int end_page_;
        private WorkerType worker_type_;
        private IDictionary<string, Image> images_;
        private string tab_name_;
        private IList<long> ids_;
        private IList<long> success_ids_;
        private bool new_direct_message_;
        private int addtion_count_;
        private PostingStatus status_;
    }


}
