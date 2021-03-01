import { BrowserModule } from '@angular/platform-browser';
import { NgModule, LOCALE_ID } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import ptBr from '@angular/common/locales/pt';
import { registerLocaleData } from '@angular/common';
registerLocaleData(ptBr)

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ContapagarDetailComponent } from './components/contapagar-detail/contapagar-detail.component';
import { ContapagarAddComponent } from './components/contapagar-add/contapagar-add.component';
import { ContapagarListComponent } from './components/contapagar-list/contapagar-list.component';
import { ContapagarDeleteComponent } from './components/contapagar-delete/contapagar-delete.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';

@NgModule({
  declarations: [
    AppComponent,
    ContapagarDetailComponent,
    ContapagarAddComponent,
    ContapagarListComponent,
    ContapagarDeleteComponent,
    PageNotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [
    { provide: LOCALE_ID, useValue: 'pt-PT' }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
