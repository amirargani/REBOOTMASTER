using REBOOTMASTER.UserControls;

namespace REBOOTMASTER.Tests.UserControls
{
    public class US_AboutTests
    {
        [Fact]
        public void US_About_Initialization_Works()
        {
            // Act
            var about = new US_About();

            // Assert
            Assert.NotNull(about);
            var copyrightLabel = about.Controls.Find("copyright_Lbl", true).FirstOrDefault() as Label;
            Assert.NotNull(copyrightLabel);
            Assert.DoesNotContain("XXXX", copyrightLabel.Text);
        }

        [Fact]
        public void US_About_InitialState_IsCorrect()
        {
            // Act
            var about = new US_About();

            // Assert
            var githubLink = about.Controls.Find("github_Lbl", true).FirstOrDefault() as Label;
            var homepageLink = about.Controls.Find("homepage_Lbl", true).FirstOrDefault() as Label;
            var logo = about.Controls.Find("pictureBox_Logo", true).FirstOrDefault() as PictureBox;

            Assert.NotNull(githubLink);
            Assert.NotNull(homepageLink);
            Assert.NotNull(logo);
            Assert.Contains("GitHub", githubLink.Text);
            Assert.True(logo.Visible);
        }
    }
}