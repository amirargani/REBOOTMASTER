using System.Runtime.InteropServices;

namespace REBOOTMASTER.Transition
{
    internal class Animate
    {
        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(nint hwnd, int dwTime, int dwFlags);

        public event Action<Animation>? AnimationStarted;
        public event Action<Animation>? AnimationEnded;

        /// <summary>
        /// Plays the specified animation on the given window handle.
        /// </summary>
        /// <param name="hwnd">The handle of the window to animate.</param>
        /// <param name="animation">The animation to play.</param>
        public void Play(nint hwnd, Animation animation)
        {
            OnStarted(animation); animation.OnStarted();
            AnimateWindow(hwnd, animation.Duration, (int)animation.Flags);
            animation.OnEnded(); OnEnded(animation);
        }

        /// <summary>
        /// Triggers the AnimationStarted event.
        /// </summary>
        /// <param name="animation">The animation that started.</param>
        protected virtual void OnStarted(Animation animation) => AnimationStarted?.Invoke(animation);

        /// <summary>
        /// Triggers the AnimationEnded event.
        /// </summary>
        /// <param name="animation">The animation that ended.</param>
        protected virtual void OnEnded(Animation animation) => AnimationEnded?.Invoke(animation);
    }
}