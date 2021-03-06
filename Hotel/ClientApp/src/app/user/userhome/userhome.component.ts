
import { UserService } from 'src/app/user/services/user.service';

import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-userhome',
  templateUrl: './userhome.component.html',
  styleUrls: ['./userhome.component.scss']
})
export class UserhomeComponent implements OnInit {

  userDetails;
  constructor(private router: Router, private service: UserService) { }
  ngOnInit() {
    this.service.getUserProfile().subscribe(
      res => {
        this.userDetails = res;
      },
      err => {
        console.log(err);
        console.log("!!!");
      },
    );
  }
  
  onLogout() {
    localStorage.removeItem('token');
    
    this.router.navigate(['/user/login']);
  }

}
