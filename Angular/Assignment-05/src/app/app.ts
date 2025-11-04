import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Table } from './components/table/table';
import { Links } from './components/links/links';
import { Lists } from './components/lists/lists';
import { NestedList } from './components/nested-list/nested-list';
import { Alert } from './components/alert/alert';
import { LeapYear } from './components/leap-year/leap-year';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Table,Links,Lists,NestedList,Alert,LeapYear],
  templateUrl: './app.html',
  styleUrls: ['./app.scss']
})
export class App {
  protected readonly title = signal('Assignment-05');
}
