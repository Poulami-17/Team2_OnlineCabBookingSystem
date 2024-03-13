import {HttpClient, HttpErrorResponse} from '@angular/common/http';
import {Injectable} from '@angular/core';
import {Router} from '@angular/router';
import {catchError, throwError} from 'rxjs';

@Injectable({providedIn: 'root'})
export class CustomerSignupService {

    private isLoggedIn = false;

    constructor(private http : HttpClient, private router : Router) {}
    signup(formData : any) { // Perform authentication logic (e.g., API call)
        this.http.post("http://localhost:5173/api/CustomerAccess/SignUp", formData).subscribe(o => {
            console.log(o);
            this.router.navigate(['']);
        });
    } catch (e : any) {
        console.log("Error", e);
    }
}
