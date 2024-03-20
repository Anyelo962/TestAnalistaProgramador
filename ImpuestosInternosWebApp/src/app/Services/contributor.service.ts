import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Contributordata } from 'src/app/Models/Contributor'
import { ResponseData } from '../Models/ResponseData';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ContributorService {

    private baseUrl = "https://localhost:7083";

   constructor(private http: HttpClient) { }


  getAllContributor(): Observable<Contributordata[]> {
    return this.http.get<Contributordata[]>(`${this.baseUrl}/api/v1/Contributor/all`)
    .pipe(map(response => Object.values(response)));
  }
}