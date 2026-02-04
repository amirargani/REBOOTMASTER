namespace REBOOTMASTER.Transition
{
    internal class Effect
    {
        private Form form { get; set; } // Form to apply effects on

        public Effect(Form _form) // Constructor
        {
            form = _form;
        }

        // Show effect by fading in
        public async Task ShowAsync()
        {
            for (double opacity = 0.0; opacity <= 1.0; opacity += 0.05)
            {
                form!.Opacity = opacity;
                await Task.Delay(50);
            }
        }

        // Hide effect by fading out
        public async Task HideAsync()
        {
            for (double opacity = 1.0; opacity >= 0.0; opacity -= 0.05)
            {
                form!.Opacity = opacity;
                await Task.Delay(50);
            }
        }

        // Slide effect from current location to target location
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

        // Fade effect in or out based on the fadeIn parameter
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

        // Center the form on the screen with a slide effect
        public async Task CenterAsync()
        {
            var screenCenter = new Point(
                Screen.PrimaryScreen!.WorkingArea.Width / 2 - form!.Width / 2,
                Screen.PrimaryScreen!.WorkingArea.Height / 2 - form!.Height / 2);
            await SlideAsync(screenCenter);
        }

        // Slide the form from right to left
        public async Task RightToLeftAsync()
        {
            var startLocation = new Point(Screen.PrimaryScreen!.WorkingArea.Width, form!.Location.Y);
            form!.Location = startLocation;
            await SlideAsync(new Point(0, form!.Location.Y));
        }

        // Slide the form from left to right
        public async Task LeftToRightAsync()
        {
            var startLocation = new Point(-form!.Width, form!.Location.Y);
            form!.Location = startLocation;
            await SlideAsync(new Point(Screen.PrimaryScreen!.WorkingArea.Width - form!.Width, form!.Location.Y));
        }

        // Slide the form from top to bottom
        public async Task TopToBottomAsync()
        {
            var startLocation = new Point(form!.Location.X, -form!.Height);
            form!.Location = startLocation;
            await SlideAsync(new Point(form!.Location.X, Screen.PrimaryScreen!.WorkingArea.Height - form!.Height));
        }

        // Slide the form from bottom to top
        public async Task BottomToTopAsync()
        {
            var startLocation = new Point(form!.Location.X, Screen.PrimaryScreen!.WorkingArea.Height);
            form!.Location = startLocation;
            await SlideAsync(new Point(form!.Location.X, 0));
        }
    }
}