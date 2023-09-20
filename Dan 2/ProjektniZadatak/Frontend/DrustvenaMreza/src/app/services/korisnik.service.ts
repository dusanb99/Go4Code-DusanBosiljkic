import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Observable, map } from "rxjs";
import { Korisnik } from "../korisnik/korisnik.model";

@Injectable ({
    providedIn: "root"
})
export class KorisnikService {

    constructor(private http: HttpClient) { }

        fetchKorisnici() : Observable<Korisnik[]> {
            var url = 'http://localhost:5167/api/Korisnik';
        
            return this.http.get<Korisnik[]>(url).pipe(
              map(response => {
                return response;
              }),
            );
          }

          createKorisnik (korisnik: Korisnik) : Observable <Korisnik> {
            var url = 'http://localhost:5167/api/Korisnik'
            var body = korisnik;

            return this.http.post<Korisnik>(url, body).pipe(
                map(response => {
                    return new Korisnik (response.ime, response.prezime, response.email, response.username, response.password);
                })
            )
          }
    }
