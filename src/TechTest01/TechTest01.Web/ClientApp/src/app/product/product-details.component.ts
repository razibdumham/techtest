
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router ,RouterModule} from '@angular/router';
@Component({
  selector: 'product-details',
  templateUrl: './product-details.component.html'
})
export class ProductdetailsComponent {
  title = 'ClientApp';
  Product: ProductDetails;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string, route: ActivatedRoute) {
    route.params.subscribe(params => {
      let id = +params['id'];
      http.get<ProductDetails>('/angular/ProductDetails/'+id).subscribe(result => {
        this.Product = result;
        console.log(result);
        console.log(this.Product);
      }, error => console.error(error));
    });

  }
}

export class ProductDetails {
  name: string;
  slug: string;
  description: string;
  price: number;
  imageUrl: string;
}

