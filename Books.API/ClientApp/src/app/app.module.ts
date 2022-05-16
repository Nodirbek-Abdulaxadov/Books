import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookComponent } from './book/book.component';
import { ViewBookComponent } from './book/view-book/view-book.component';
import { AddEditBookComponent } from './book/add-edit-book/add-edit-book.component';
import { CategoryComponent } from './category/category.component';
import { ShowCategoryComponent } from './category/show-category/show-category.component';
import { AddEditCategoryComponent } from './category/add-edit-category/add-edit-category.component';

import { CategoryService } from './category/category.service';

@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    ViewBookComponent,
    AddEditBookComponent,
    CategoryComponent,
    ShowCategoryComponent,
    AddEditCategoryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
