import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { ContapagarAddComponent } from './components/contapagar-add/contapagar-add.component';
import { ContapagarDeleteComponent } from './components/contapagar-delete/contapagar-delete.component';
import { ContapagarDetailComponent } from './components/contapagar-detail/contapagar-detail.component';
import { ContapagarListComponent } from './components/contapagar-list/contapagar-list.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';

const routes: Routes = [
  { path: '', redirectTo: 'contapagar', pathMatch: 'full' },
  { path: 'contapagar', component: ContapagarListComponent },
  { path: 'contapagar/detail/:id', component: ContapagarDetailComponent },
  { path: 'contapagar/delete/:id', component: ContapagarDeleteComponent },
  { path: 'contapagar/add', component: ContapagarAddComponent },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
