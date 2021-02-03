
import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'product-root',
  templateUrl: './product.component.html'
})
export class ProductDataComponent {
  title = 'ClientApp';
  productList: product[];
  constructor(http: HttpClient) {
    http.get<product[]>('/angular/HopmePageProducts').subscribe(result => {
      this.productList = result;
      console.log(result);
      console.log(this.productList);
    }, error => console.error(error));
  }
}

export class product {
  name: string;
  slug: string;
  description: string;
  price: number;
  imageUrl: string;
}

