import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Comprobantes } from '../Models/Comprobantes';
import { Contribuyentes } from '../Models/Contribuyentes';

@Injectable({
  providedIn: 'root'
})
export class ContribuyentesService {

  constructor(private httpClient: HttpClient) { }

  readonly apiUrl = "https://localhost:7293/api/";

  getContribuyentes(): Observable<Contribuyentes[]> {
    return this.httpClient.get<Contribuyentes[]>(this.apiUrl + "contribuyentes");
  }

  getComprobantes(rncCedula: number): Observable<Comprobantes[]> {
    return this.httpClient.get<Comprobantes[]>(this.apiUrl + "contribuyentes/" + rncCedula);
  }
}
