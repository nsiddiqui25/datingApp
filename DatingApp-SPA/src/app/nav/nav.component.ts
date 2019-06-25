import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { iif } from 'rxjs';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  login() {
    // console.log(this.model);
    this.authService.login(this.model).subscribe(next => {
      // console.log('Login success');
      this.alertify.success('Logged in successfully!');
    }, error => {
      // console.log(error);
      this.alertify.error(error);
    });
  }

  loggedIn() {
    return this.authService.loggedIn();
  }

  logout() {
    localStorage.removeItem('token');
    // console.log('logged out');
    this.alertify.message('You have been logged out!');
  }

}
