import { Component, OnInit } from '@angular/core';

import { Person } from '../../person';
import { PersonService } from '../../person.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss'],
})
export class HomePageComponent implements OnInit {
  people: Person[];

  constructor(private peopleService: PersonService) {}

  ngOnInit(): void {
    this.getPeople();
  }

  getPeople(): void {
    this.peopleService
      .getPeople()
      .subscribe((people) => (this.people = people));
  }
}
