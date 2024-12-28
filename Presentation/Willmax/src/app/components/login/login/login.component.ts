import { Component } from '@angular/core';
import { AuthService } from '../../../services/auth-service/auth.service';
import { LoginRequest } from '../../../models/LoginRequest';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  constructor(private service: AuthService) { }

  login:LoginRequest = new LoginRequest();

  submit() {
      this.service.login(this.login);
  }
}
