export interface Person {
    id?: number;
    name: string;
    gender?: string;
    email?: string;
    dateOfBirth: string; // ISO format date
    nationality?: string;
    identification: string; // Must be validated for format and uniqueness
    createdAt?: Date;
    updatedAt?: Date;
}