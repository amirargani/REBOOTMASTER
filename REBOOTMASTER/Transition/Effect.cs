namespace REBOOTMASTER_Free.Transition
{
    internal class Effect
    {
        private Form form { get; set; }

        public Effect(Form _form)
        {
            form = _form;
        }

        public async Task ShowAsync()
        {
            for (double opacity = 0.0; opacity <= 1.0; opacity += 0.05)
            {
                form!.Opacity = opacity;
                await Task.Delay(50);
            }
        }

        public async Task HideAsync()
        {
            for (double opacity = 1.0; opacity >= 0.0; opacity -= 0.05)
            {
                form!.Opacity = opacity;
                await Task.Delay(50);
            }
        }

        public async Task SlideAsync(Point targetLocation)
        {
            var startLocation = form!.Location;
            for (int i = 0; i < 100; i++)
            {
                form!.Location = new Point(
                    startLocation.X + (targetLocation.X - startLocation.X) * i / 100,
                    startLocation.Y + (targetLocation.Y - startLocation.Y) * i / 100);
                await Task.Delay(10);
            }
            form!.Location = targetLocation;
        }

        public async Task FadeAsync(bool fadeIn)
        {
            if (fadeIn)
            {
                for (double opacity = 0.0; opacity <= 1.0; opacity += 0.05)
                {
                    form!.Opacity = opacity;
                    await Task.Delay(50);
                }
            }
            else
            {
                for (double opacity = 1.0; opacity >= 0.0; opacity -= 0.05)
                {
                    form!.Opacity = opacity;
                    await Task.Delay(50);
                }
            }
        }

        public async Task CenterAsync()
        {
            var screenCenter = new Point(
                Screen.PrimaryScreen!.WorkingArea.Width / 2 - form!.Width / 2,
                Screen.PrimaryScreen!.WorkingArea.Height / 2 - form!.Height / 2);
            await SlideAsync(screenCenter);
        }

        public async Task RightToLeftAsync()
        {
            var startLocation = new Point(Screen.PrimaryScreen!.WorkingArea.Width, form!.Location.Y);
            form!.Location = startLocation;
            await SlideAsync(new Point(0, form!.Location.Y));
        }

        public async Task LeftToRightAsync()
        {
            var startLocation = new Point(-form!.Width, form!.Location.Y);
            form!.Location = startLocation;
            await SlideAsync(new Point(Screen.PrimaryScreen!.WorkingArea.Width - form!.Width, form!.Location.Y));
        }

        public async Task TopToBottomAsync()
        {
            var startLocation = new Point(form!.Location.X, -form!.Height);
            form!.Location = startLocation;
            await SlideAsync(new Point(form!.Location.X, Screen.PrimaryScreen!.WorkingArea.Height - form!.Height));
        }

        public async Task BottomToTopAsync()
        {
            var startLocation = new Point(form!.Location.X, Screen.PrimaryScreen!.WorkingArea.Height);
            form!.Location = startLocation;
            await SlideAsync(new Point(form!.Location.X, 0));
        }
    }
}
