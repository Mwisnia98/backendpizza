import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { animate, style, transition, trigger } from '@angular/animations';

@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.sass'],
  animations: [
    trigger(
      'inOutAnimation', 
      [
        transition(
          ':enter', 
          [
            style({ height: 0, opacity: 0 }),
            animate('1s ease-out', 
                    style({ height: 300, opacity: 1 }))
          ]
        ),
        transition(
          ':leave', 
          [
            style({ height: 300, opacity: 1 }),
            animate('1s ease-in', 
                    style({ height: 0, opacity: 0 }))
          ]
        )
      ]
    )
  ]
})
export class LoginComponent implements OnInit {
  public showRegister: boolean = false;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
    console.log(http)
    console.log(baseUrl + 'api/User');
    http.get<string>('https://localhost:7274/api/User').subscribe((val) => {
      console.log(val);
    });
  }

  ngOnInit() {
    this.showRegister = false;
  }
  

  handleClickRegister() {
    this.showRegister = !this.showRegister;
  }

}
