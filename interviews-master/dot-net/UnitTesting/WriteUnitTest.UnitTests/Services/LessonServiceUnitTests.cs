using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WriteUnitTest.UnitTests.Services
{
    [TestClass]
    public class LessonServiceUnitTests
    {
        [TestMethod]
        public void UpdateLessonGradeFailTest()
        {
            var lessonSVC = new LessonService();
            Assert.IsTrue(!lessonSVC.UpdateLessonGrade(12, 79));
        }

		[TestMethod]
		public void UpdateLessonGradePassTest()
		{
			var lessonSVC = new LessonService();
			Assert.IsTrue(lessonSVC.UpdateLessonGrade(12, 85));
		}

    }
}