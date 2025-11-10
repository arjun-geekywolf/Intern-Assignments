import { Component } from '@angular/core';
import { NavBar } from '../nav-bar/nav-bar';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './home.html',
  styleUrls: ['./home.scss'],
})
export class Home {

}
