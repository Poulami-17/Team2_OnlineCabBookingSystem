import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Route, Router } from '@angular/router';
import { catchError, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DriverLoginService {

  private isLoggedIn=true;
  // valid: any;
  constructor(private http: HttpClient, private router:Router) { }
   login(formData:any){
    this.http.post("http://localhost:5173/api/DriverAccess/SignIn",formData)
    
      .subscribe((o:any) => {
        console.log(o);
        console.log("Logged in Successfully!");
        localStorage.setItem("accessToken",JSON.stringify(o));
        this.isLoggedIn=true;
      }, (e) => {
        console.error('Login Failed',e);
        alert("Invalid Credentials");
      });

      this.router.navigate(['/Accept']);
   }
}
