import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Router } from '@angular/router';

import { AppComponent } from './app.component';
import { ProductDataComponent } from './product/product.component';

import { ProductdetailsComponent } from './product/product-details.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductDataComponent,
    ProductdetailsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
    ,
     RouterModule.forRoot([
       { path: 'angular/index', component: ProductDataComponent, pathMatch: 'full' },
        //{ path: 'counter', component: CounterComponent },
       { path: 'angular/product/:id', component: ProductdetailsComponent, pathMatch: 'full' },
     ])
  ],
  providers: [],
  bootstrap: [ProductDataComponent]
})
export class AppModule { }
