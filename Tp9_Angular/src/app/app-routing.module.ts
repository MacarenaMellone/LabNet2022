import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormComponent } from './modules/formulario/form/form.component';
import { HomeComponent } from './modules/formulario/home/home.component';
import { ListShippersComponent } from './modules/formulario/list-shippers/list-shippers.component';
const routes: Routes = [
  {
    path: 'form',
    component: FormComponent
  },
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'listShippers',
    component: ListShippersComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }