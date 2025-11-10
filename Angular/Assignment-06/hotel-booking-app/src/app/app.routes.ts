import { Routes } from '@angular/router';
import { Home } from './features/home/home';
import { HotelDetails } from './features/hotels/hotel-details/hotel-details';
import { HotelList } from './features/hotels/hotel-list/hotel-list';
import { Customers } from './features/customers/customers/customers';
import { CustomerDetails } from './features/customers/customer-details/customer-details';
import { RoomsList } from './features/hotels/rooms-list/rooms-list';
import { Reviews } from './features/hotels/reviews/reviews';
import { Employees } from './features/hotels/employees/employees';

export const routes: Routes = [
    { path: '', component: Home },
    { path: 'hotel-list', component: HotelList },
    { path: 'hotels/:id', component: HotelDetails, children:[
        { path: 'rooms-list', component: RoomsList },
        { path: 'employees', component: Employees },
        { path: 'reviews', component: Reviews,},
        { path: '', redirectTo: 'rooms-list', pathMatch: 'full' }
    ]},
    { path: 'customers', component: Customers },
    { path: 'customers/:id', component: CustomerDetails ,children:[
        {  path:'customer-details', component: CustomerDetails},
        {path:'', redirectTo:'customer-details', pathMatch:'full' }
    ]
    }
];
