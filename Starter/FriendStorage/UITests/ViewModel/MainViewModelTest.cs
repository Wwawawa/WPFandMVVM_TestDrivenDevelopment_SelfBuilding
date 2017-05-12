
using System;
using FriendStorage.UI.ViewModel;
using Xunit;

namespace UITests.ViewModel
{
    public class MainViewModelTest
    {
        [Fact]
        public void ShouldCallLoadMethodOfNavigationViewModel()
        {
            var navigationViewModelMock = new NavigationViewModelMock();
            var viewModel = new MainViewModel(navigationViewModelMock);

            viewModel.Load();

            Assert.True(navigationViewModelMock.LoadHasBeenCalled);
        }
    }
    public class NavigationViewModelMock : INavigationViewModel
    {
        public bool LoadHasBeenCalled { get; set; }
        public void Load()
        {
            LoadHasBeenCalled = true;
        }
    }
}
