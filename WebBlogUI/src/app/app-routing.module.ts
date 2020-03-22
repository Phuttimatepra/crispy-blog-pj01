import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FirstTimesComponent } from './components/first-times/first-times.component';
import { Page2Component } from './components/page2/page2/page2.component';


const routes: Routes = [
  {
    path:'home',
    component: FirstTimesComponent
  },
  {
    path: 'page2',
    component: Page2Component
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
