export class Korisnik  {

    ime: string;

    prezime: string;

    email: string;

    username: string;

    password: string
    

    constructor (ime: string, prezime: string, email:string, username: string, password: string) {
        this.ime = ime;
        this.prezime = prezime;
        this.email = email;
        this.username = username;
        this.password = password;

    }
}