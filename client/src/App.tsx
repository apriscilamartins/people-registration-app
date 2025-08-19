import React from 'react';
import RegisterForm from './components/RegisterForm';

const App: React.FC = () => {
    return (
        <div className="App">
            <h1>People Registration</h1>
            <RegisterForm />
        </div>
    );
};

export default App;