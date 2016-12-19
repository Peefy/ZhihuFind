using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ZhihuFind.Droid.ViewModel
{
    public class BestAnswererModel 
    {
        /// <summary>
        /// ����
        /// </summary>
        public IList<int> Topics { get; set; }
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string Description { get; set; }
    }
}