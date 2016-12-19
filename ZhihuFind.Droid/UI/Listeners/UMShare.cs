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
using Com.Umeng.Socialize;
using Com.Umeng.Socialize.Bean;
using Java.Lang;

namespace ZhihuFind.Droid.UI.Listeners
{
    public class UMShare : Java.Lang.Object, IUMShareListener
    {
        private Context context;
        public UMShare(Context context)
        {
            this.context = context;
        }
        public void OnCancel(SHARE_MEDIA platform)
        {
            Toast.MakeText(context, "����ȡ����", ToastLength.Short).Show();
        }
        public void OnError(SHARE_MEDIA platform, Throwable p1)
        {
            Toast.MakeText(context, "����ʧ����", ToastLength.Short).Show();
        }
        public void OnResult(SHARE_MEDIA platform)
        {
            if (platform.Name().Equals("WeixinFavorite"))
            {
                Toast.MakeText(context, "�ղسɹ���", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(context, "����ɹ���", ToastLength.Short).Show();
            }
        }
    }
}