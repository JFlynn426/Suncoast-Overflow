import React, { Component } from 'react'

export class Answers extends Component {
    static displayName = Answers.name

    render() {
        return (
            <div>
                <h4>Questions</h4>
                <div className="PostedQuestion">
                    <div className="VoteButton">
                        <button className="VoteButton">Vote Up</button>
                        <button className="VoteButton">Vote Down</button>
                    </div>
                    <div className="Question">
                        <p>
                            Lorem Ipsum QUESTION: I find demos on how to debug .net core apps
                            in Visual Studio everywhere but not for Angular and VS Code. The
                            only thing I see out there is how to deploy an Angular app using
                            VS Code, Docker, Kubernetes, etc. Nothing for debugging in VS
                            Code. Is this possible? If so, can someone direct me on how to
                            configure VS Code to allow me to do this?
            </p>
                        <div className="CreatedTimeAndAuthor">
                            <div>Modified 2 minutes ago</div>
                            <div>Author's name</div>
                        </div>
                    </div>
                </div>
                <h4>Answers</h4>
                <div className="PostedAnswer">
                    <div className="VoteButton">
                        <button className="VoteButton">Vote Up</button>
                        <button className="VoteButton">Vote Down</button>
                    </div>
                    <div className="Answer">
                        <p>
                            Lorem Ipsum ANSWER: I find demos on how to debug .net core apps in
                            Visual Studio everywhere but not for Angular and VS Code. The only
                            thing I see out there is how to deploy an Angular app using VS
                            Code, Docker, Kubernetes, etc. Nothing for debugging in VS Code.
                            Is this possible? If so, can someone direct me on how to configure
                            VS Code to allow me to do this?
            </p>
                        <div className="CreatedTimeAndAuthor">
                            <div>Modified 2 minutes ago</div>
                            <div>Author's name</div>
                        </div>
                    </div>
                </div>
                <h4>Post Your Answer</h4>
                <div className="Header">
                    <textarea
                        id="story"
                        name="story"
                        rows="1"
                        cols="40"
                        placeholder="Title"
                    />
                    <button>Submit Answer</button>
                </div>

                <div className="Titles">
                    <div className="Questions">
                        <textarea
                            id="story"
                            name="story"
                            rows="10"
                            cols="40"
                            placeholder="Answer"
                        />

                        <div class="CreatedTimeAndAuthor">
                            <div>Modified 2 minutes ago</div>
                            <input type="text" placeholder="Author" />
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}

export default Answers
