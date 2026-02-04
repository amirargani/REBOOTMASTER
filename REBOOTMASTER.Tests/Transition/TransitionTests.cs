using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using REBOOTMASTER.Transition;
using Xunit;

namespace REBOOTMASTER.Tests.Transition
{
    public class AnimationTests
    {
        [Fact]
        public void Animation_OnStarted_OnEnded_InvokesEvents()
        {
            var animation = new Animation();
            bool started = false, ended = false;
            animation.AnimationStarted += a => started = true;
            animation.AnimationEnded += a => ended = true;

            // Act
            animation.OnStarted();
            animation.OnEnded();

            // Assert
            Assert.True(started);
            Assert.True(ended);
        }
    }

    public class AnimateTests
    {
        [Fact]
        public void Play_TriggersEvents_OnAnimateAndAnimation()
        {
            var animation = new Animation { Duration = 1, Flags = Animation.AnimationFlags.Fade };
            bool animationStarted = false, animationEnded = false;
            animation.AnimationStarted += a => animationStarted = true;
            animation.AnimationEnded += a => animationEnded = true;

            var animate = new Animate();
            bool animateStarted = false, animateEnded = false;
            animate.AnimationStarted += a => animateStarted = true;
            animate.AnimationEnded += a => animateEnded = true;

            // Act
            animate.Play(nint.Zero, animation);

            // Assert
            Assert.True(animationStarted);
            Assert.True(animationEnded);
            Assert.True(animateStarted);
            Assert.True(animateEnded);
        }
    }

    public class EffectTests
    {
        [Fact]
        public async Task ShowAsync_SetsOpacityToOne()
        {
            using var form = new Form();
            form.Opacity = 0.0;
            var effect = new Effect(form);

            await effect.ShowAsync();

            // Allow a small rounding tolerance as opacity is incremented in steps
            Assert.InRange(form.Opacity, 0.95, 1.0);
        }

        [Fact]
        public async Task HideAsync_SetsOpacityToZero()
        {
            using var form = new Form();
            form.Opacity = 1.0;
            var effect = new Effect(form);

            await effect.HideAsync();

            // Allow a small rounding tolerance as opacity is decremented in steps
            Assert.InRange(form.Opacity, 0.0, 0.05);
        }

        [Fact]
        public async Task SlideAsync_MovesToTarget()
        {
            using var form = new Form();
            var start = new Point(0, 0);
            var target = new Point(100, 50);
            form.Location = start;
            var effect = new Effect(form);

            await effect.SlideAsync(target);

            Assert.Equal(target, form.Location);
        }
    }
}
