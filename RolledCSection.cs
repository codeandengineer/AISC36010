using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISC36010
{
    public class RolledCSection : ISection
    {
        private float _d;
        private float _h;
        private float _b;
        private float _tf;
        private float _tw;
        private float _rToe;
        private float _rRoot;

        public float d
        {
            get
            {
                return this._d;
            }
            set
            {
                this._d = value;
            }
        }

        public float h
        {
            get
            {
                return this._h;
            }
            set
            {
                this._h = value;
            }
        }

        public float b
        {
            get
            {
                return this._b;
            }
            set
            {
                this._b = value;
            }
        }

        public float tf
        {
            get
            {
                return this._tf;
            }
            set
            {
                this._tf = value;
            }
        }

        public float tw
        {
            get
            {
                return this._tw;
            }
            set
            {
                this._tw = value;
            }
        }

        public float rToe
        {
            get
            {
                return this._rToe;
            }
            set
            {
                this._rToe = value;
            }
        }

        public float rRoot
        {
            get
            {
                return this._rRoot;
            }
            set
            {
                this._rRoot = value;
            }
        }
    }
}
