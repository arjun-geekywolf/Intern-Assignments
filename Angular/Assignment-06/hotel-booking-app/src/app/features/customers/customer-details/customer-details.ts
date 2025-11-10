import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { customerService } from '../../../services/customer';

@Component({
  selector: 'app-customer-details',
  imports: [],
  templateUrl: './customer-details.html',
  styleUrl: './customer-details.scss',
})
export class CustomerDetails {

  customer: any;

  constructor(
    private router: Router,
    private customerService: customerService
  ) {}

  ngOnInit() {
    const customerId = Number(this.router.url.split('/')[2]);
    this.customerService.getCustomerDetails(customerId).subscribe(customer => {
      this.customer = customer;
    });
  }
}
