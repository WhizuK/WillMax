import { User } from "./User";

export class  LoginResponse {
    constructor() {
        this.user = new User();
        this.token = '';
        this.refreshToken = '';
    };

    user: User;
    token: string;
    refreshToken: string;
}