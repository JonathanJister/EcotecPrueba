import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ContactoModel } from '../models/contactoModel';

@Injectable({
  providedIn: 'root'
})
export class ContactoService {
  myApUrl = 'https://localhost:44342/';
  myApiUrl = 'api/Contactoes/';

  constructor(private http: HttpClient) { }

  guardarContacto(contacto: ContactoModel): Observable<ContactoModel>{
    return this.http.post<ContactoModel>(this.myApUrl + this.myApiUrl, contacto);
  }
}
