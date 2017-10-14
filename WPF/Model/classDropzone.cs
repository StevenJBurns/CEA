using System;
using System.Collections.Generic;
using System.Text;

namespace CEA.Model
    {
    public class Dropzone
        {
        private String dz_id;
        private String dz_name;
        private bool dz_common;
        private bool dz_activerecord;

        public String DZ_ID
            {
            get { return dz_id; }
            set { dz_id = value; }
            }

        public String Name
            {
            get { return dz_name; }
            set { dz_name = value; }
            }

        public bool CommonUse
            {
            get { return dz_common; }
            set { dz_common = value; }
            }

        public bool ActiveRecord
            {
            get { return dz_activerecord; }
            set { dz_activerecord = value; }
            }


        public Dropzone()
            {
            this.dz_name = "Name Not Set";
            this.dz_id = "ID Not Set";
            this.dz_common = true;
            this.dz_activerecord = true;
            }

        public Dropzone(String id, String name, bool common)
            {
            this.dz_id = id;
            this.dz_name = name;
            this.dz_common = common;
            this.dz_activerecord = true;
            }

        }
    }