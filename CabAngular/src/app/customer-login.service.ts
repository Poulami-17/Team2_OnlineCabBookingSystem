import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CustomerLoginService {
  private isLoggedIn = false;
 
  constructor(private http: HttpClient, private router: Router) { }
 
  login(formData: any) {
    // Perform authentication logic (e.g., API call)
    this.http.post("http://localhost:5173/api/CustomerAccess/SignIn", formData)
      .pipe(
        catchError((error: HttpErrorResponse) => {
          console.error('Login failed:', error);
          alert("Invalid credentials");
          return throwError(error); // Rethrow the error
        })
      )
      .subscribe((o: any) => {
        console.log(o);
        console.log("Logged in successfully");
        localStorage.setItem("accessToken", JSON.stringify(o));
        this.isLoggedIn = true;

        this.router.navigate(['/rideBook']);
      });
}
}
