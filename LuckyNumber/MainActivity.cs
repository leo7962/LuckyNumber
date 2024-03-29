﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@mipmap/First_Icon")]
    public class MainActivity : AppCompatActivity
    {
        private SeekBar seekBar;
        private TextView resultTextView;
        private Button rollButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            if (resultTextView != null) resultTextView.Text = "5";
            rollButton = FindViewById<Button>(Resource.Id.rollButton);
            if (rollButton != null) rollButton.Click += RollButton_Click;

            SupportActionBar.Title = "My Lucky Number App";
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var luckyNumber = random.Next(seekBar.Progress) + 1;
            resultTextView.Text = luckyNumber.ToString();
        }
    }
}