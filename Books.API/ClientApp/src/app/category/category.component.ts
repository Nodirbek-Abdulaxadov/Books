import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../category/category.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-category',
  templateUrl: './category.component.html',
  styleUrls: ['./category.component.css'],
})
export class CategoryComponent implements OnInit {

  Categories$! : Observable<any[]>;

  constructor(private service: CategoryService) { }

  ngOnInit(): void {
    this.Categories$ = this.service.getCategories();
  }

}
