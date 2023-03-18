using CommunityToolkit.Mvvm.Input;
using HandyControl.Controls;
using System.Windows.Media.Imaging;
using System;
using System.Windows.Controls;
using HappySLMS.Wpf.Views.Sprites;
using System.Reflection.Metadata;
using System.Windows;
using CommunityToolkit.Mvvm.Messaging;
using HappySLMS.Wpf.Messages;
using System.Windows.Input;
using System.Windows.Media;

namespace HappySLMS.Wpf.ViewModels
{
    public partial class GamePageViewModel : ViewModelBase
    {
        private Sprite? gameSprite;

        private TimeSpan lastFrameTime;
        [RelayCommand]
        void OpenCmd()
        {

            if (gameSprite is not null) return;
            gameSprite = Sprite.Show(new GameSprite());
            lastFrameTime = TimeSpan.Zero;
            CompositionTarget.Rendering += (s, e) =>
            {
                var nextFrameTime = (e as RenderingEventArgs).RenderingTime;
                var deltaTime = nextFrameTime - lastFrameTime;
                lastFrameTime = nextFrameTime;
                var vectorUp = new Vector(0, 0);
                var vectorDown = new Vector(0, 0);
                var vectorLeft = new Vector(0, 0);
                var vectorRight = new Vector(0, 0);

                if (Keyboard.IsKeyDown(Key.W))
                {
                    vectorUp.Y = -1;
                }
                if (Keyboard.IsKeyDown(Key.S))
                {
                    vectorDown.Y = 1;
                }
                if (Keyboard.IsKeyDown(Key.A))
                {
                    vectorLeft.X = -1;
                }
                if (Keyboard.IsKeyDown(Key.D))
                {
                    vectorRight.X = 1;
                }
                var result = vectorUp + vectorDown + vectorLeft + vectorRight;
                if (result.X == 0 && result.Y == 0) return;
                result.Normalize();
                var speed = 500.0;
                var moveDirection = speed* deltaTime.TotalSeconds * result;
                gameSprite.Left += moveDirection.X;
                gameSprite.Top += moveDirection.Y;

            };

            //WeakReferenceMessenger.Default.Register<KeyDownMessage>(this, (r, m) =>
            //{

            //    switch (m.Value.Key)
            //    {
            //        // 向左移动
            //        case Key.A:
            //            gameSprite.Left -=50;
            //            break;

            //        // 向右移动
            //        case Key.D:
            //            gameSprite.Left += 50;
            //            break;

            //        // 向上移动
            //        case Key.W:
            //            gameSprite.Top -= 50;
            //            break;

            //        // 向下移动
            //        case Key.S:
            //            gameSprite.Top += 50;
            //            break;
            //    }
            //});
        }
    }

}
