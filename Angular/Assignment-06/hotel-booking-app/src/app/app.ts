import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Home } from './features/home/home';

import { NavBar } from "./features/nav-bar/nav-bar";
import { Customers } from './features/customers/customers/customers';
import { CustomerDetails } from './features/customers/customer-details/customer-details';
import { HotelList } from './features/hotels/hotel-list/hotel-list';
import { HotelDetails } from './features/hotels/hotel-details/hotel-details';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,NavBar],
  templateUrl: './app.html',
  styleUrls: ['./app.scss']
})
export class App {
  protected readonly title = signal('hotel-booking-app');
}
