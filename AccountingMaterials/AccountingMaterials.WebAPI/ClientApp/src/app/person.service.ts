import { Injectable } from '@angular/core';

import { Person } from './person';
import { PEOPLE } from './people';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PersonService {
  constructor() {}

  getPeople(): Observable<Person[]> {
    const people = of(PEOPLE);
    return people;
  }

  getPerson(id: number): Observable<Person> {
    const person = PEOPLE.find((p) => p.id === id) as Person;
    return of(person);
  }
}
