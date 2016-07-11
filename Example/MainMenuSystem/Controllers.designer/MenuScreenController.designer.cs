// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    
    public class MenuScreenControllerBase : SubScreenController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager _MenuScreenViewModelManager;
        
        [uFrame.IOC.InjectAttribute("MenuScreen")]
        public uFrame.MVVM.ViewModels.IViewModelManager MenuScreenViewModelManager {
            get {
                return _MenuScreenViewModelManager;
            }
            set {
                _MenuScreenViewModelManager = value;
            }
        }
        
        public IEnumerable<MenuScreenViewModel> MenuScreenViewModels {
            get {
                return MenuScreenViewModelManager.OfType<MenuScreenViewModel>();
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeMenuScreen(((MenuScreenViewModel)(viewModel)));
        }
        
        public virtual MenuScreenViewModel CreateMenuScreen() {
            return ((MenuScreenViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new MenuScreenViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeMenuScreen(MenuScreenViewModel viewModel) {
            // This is called when a MenuScreenViewModel is created
            MenuScreenViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            MenuScreenViewModelManager.Remove(viewModel);
        }
    }
}