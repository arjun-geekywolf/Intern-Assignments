import { Component } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { customerService } from '../../../services/customer';
import { CustomerCard } from '../../../shared/customer-card/customer-card';

@Component({
  selector: 'app-customers',
  imports: [CustomerCard],
  templateUrl: './customers.html',
  styleUrl: './customers.scss',
})
export class Customers {

customers: any[] = [];

constructor(
    private router: Router,
    private customerService: customerService
  ) {}

  ngOnInit() {
    this.customerService.getCustomers().subscribe((data) => {
      this.customers = data;
    });
  }

  navigate(route: string) {
    this.router.navigate([route]);
  }

}
