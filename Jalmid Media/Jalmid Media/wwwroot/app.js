// News data - in a real application, this would come from an API
const newsData = {
    1: {
        id: 1,
        title: "New AI Breakthrough Changes How We Interact With Technology",
        category: "Technology",
        date: "May 18, 2025",
        content: `
            <p>Researchers have developed a revolutionary AI system that can understand and respond to human emotions with unprecedented accuracy, potentially transforming how we interact with technology in our daily lives.</p>
            
            <p>The breakthrough, announced yesterday by a team of international researchers, represents a significant leap forward in emotional intelligence for artificial systems. The new AI can detect subtle facial expressions, voice modulations, and even physiological signals to gauge a person's emotional state with over 95% accuracy.</p>
            
            <p>"This is not just about making machines that can recognize when someone is happy or sad," explains Dr. Sarah Chen, lead researcher on the project. "It's about creating systems that can understand the nuanced emotional context of human interaction and respond appropriately."</p>
            
            <p>The technology has immediate applications in fields ranging from mental health support to customer service. Early trials have shown promising results in therapeutic settings, where the AI has been used to provide initial assessments and ongoing support for patients with anxiety and depression.</p>
            
            <p>In customer service scenarios, the technology could transform automated support systems by allowing them to detect customer frustration early and adjust their responses accordingly or route complex cases to human agents more efficiently.</p>
            
            <p>Privacy advocates have raised concerns about the potential for misuse of emotion-detecting technologies, particularly in surveillance or marketing contexts. The research team acknowledges these concerns and emphasizes the importance of ethical guidelines for deployment.</p>
            
            <p>"We've built privacy considerations into the system from the ground up," says Dr. Chen. "The AI processes emotional data locally whenever possible, rather than sending it to cloud servers, and we're working with ethicists to develop clear usage policies."</p>
            
            <p>The team plans to release a limited version of the technology to select research partners later this year, with broader commercial applications expected to follow in 2026.</p>
        `
    },
    2: {
        id: 2,
        title: "Global Markets Reach Record Highs",
        category: "Business",
        date: "May 17, 2025",
        content: `
            <p>Stock markets around the world have reached unprecedented levels as economic recovery continues to exceed expectations.</p>
            
            <p>Major indices in New York, London, Tokyo, and Shanghai all closed at record highs yesterday, extending a rally that has now continued for six consecutive weeks. The surge comes as inflation concerns have eased and corporate earnings reports have consistently outperformed analyst expectations.</p>
            
            <p>"We're seeing the culmination of several positive factors," explains Maria Rodriguez, chief market strategist at Global Investments. "Supply chain issues that plagued the economy last year have largely resolved, central banks have managed to navigate a soft landing after rate hikes, and consumer spending remains robust."</p>
            
            <p>Technology and renewable energy sectors have led the rally, with particularly strong performances from companies focused on artificial intelligence and green hydrogen production. Traditional manufacturing and financial services have also posted solid gains, indicating the breadth of the economic recovery.</p>
            
            <p>Economists remain cautiously optimistic about the outlook for the remainder of the year, though some warn that the market may be approaching overvalued territory.</p>
            
            <p>"The fundamentals are strong, but we're seeing some signs of exuberance in certain sectors," notes Dr. James Park, economist at Capital University. "Investors should maintain diversified portfolios and be prepared for potential volatility."</p>
            
            <p>Small business confidence has also reached a five-year high, according to surveys released this week, suggesting that economic optimism extends beyond Wall Street to Main Street.</p>
            
            <p>Consumer spending data released yesterday showed a 3.2% increase compared to the same period last year, further supporting the positive economic outlook that has fueled the market rally.</p>
        `
    },
    3: {
        id: 3,
        title: "New Study Reveals Benefits of Intermittent Fasting",
        category: "Health",
        date: "May 16, 2025",
        content: `
            <p>A comprehensive study has found significant health benefits associated with various intermittent fasting protocols.</p>
            
            <p>The research, published yesterday in the Journal of Metabolic Health, followed over 5,000 participants for a three-year period and found that those who practiced intermittent fasting showed improvements in insulin sensitivity, inflammatory markers, and overall metabolic health compared to control groups.</p>
            
            <p>"What's particularly interesting is that we saw benefits across different fasting protocols," explains Dr. Michael Patel, the study's lead author. "Whether participants were doing time-restricted eating within an 8-hour window or practicing the 5:2 method with two low-calorie days per week, the metabolic improvements were significant."</p>
            
            <p>The study found that participants who maintained intermittent fasting regimens for at least six months experienced an average 9% reduction in visceral fat, the dangerous fat that surrounds internal organs and is associated with higher risks of heart disease and diabetes.</p>
            
            <p>Cognitive benefits were also observed, with fasting groups showing improved memory and cognitive flexibility in standardized tests compared to baseline measurements.</p>
            
            <p>However, researchers emphasized that intermittent fasting is not appropriate for everyone. "Pregnant women, people with a history of eating disorders, and those with certain medical conditions should avoid fasting without medical supervision," cautions Dr. Lisa Chen, a nutrition expert not involved in the study.</p>
            
            <p>The research team is now planning follow-up studies to determine the optimal fasting protocols for different age groups and health conditions.</p>
            
            <p>"This isn't a one-size-fits-all approach," says Dr. Patel. "But our research suggests that for many people, incorporating some form of intermittent fasting into their lifestyle could yield significant health benefits."</p>
        `
    },
    4: {
        id: 4,
        title: "Renewable Energy Surpasses Fossil Fuels",
        category: "Environment",
        date: "May 15, 2025",
        content: `
            <p>For the first time in history, renewable energy sources have generated more electricity than fossil fuels on a global scale.</p>
            
            <p>According to data released yesterday by the International Energy Agency (IEA), renewable sources including solar, wind, hydroelectric, and geothermal power accounted for 51.3% of global electricity generation in the first quarter of 2025, marking a historic milestone in the transition to clean energy.</p>
            
            <p>"This is a watershed moment in the global energy transition," said Emma Thompson, executive director of the IEA. "Just a decade ago, many experts doubted that renewables could ever surpass fossil fuels in the global energy mix. Today's data proves not only that it's possible, but that it's happening faster than most predictions suggested."</p>
            
            <p>The shift has been driven by several factors, including dramatic cost reductions in solar and wind technologies, increased energy storage capacity, and policy support for clean energy in major economies including China, the European Union, and increasingly, the United States.</p>
            
            <p>Solar power showed the most dramatic growth, with global capacity increasing by 32% compared to the same period last year. Wind power capacity grew by 21%, while battery storage capacity more than doubled, helping to address intermittency issues that have historically limited renewable energy adoption.</p>
            
            <p>The milestone comes as global carbon dioxide emissions from the energy sector have begun to decline for the first time outside of a major economic recession, falling by 2.7% in 2024 despite economic growth of 3.1%.</p>
            
            <p>Energy analysts caution that maintaining this trajectory will require continued policy support and investment in grid infrastructure and energy storage.</p>
            
            <p>"This is an encouraging sign, but we need to accelerate the transition," said Dr. Robert Chen, climate scientist at Pacific University. "To meet climate goals, we need to completely phase out fossil fuels from electricity generation by 2040 and rapidly electrify transportation and industrial processes."</p>
        `
    },
    5: {
        id: 5,
        title: "Underdog Team Wins Championship",
        category: "Sports",
        date: "May 14, 2025",
        content: `
            <p>In a stunning upset, the underdog team has defeated the reigning champions to claim their first title in 50 years.</p>
            
            <p>The victory came after a nail-biting final match that went into overtime, with the winning goal scored in the final minutes by rookie player Jamie Rodriguez, who had been called up from the reserve team just three weeks ago due to injuries on the main roster.</p>
            
            <p>"I still can't believe it," said Rodriguez in the post-game press conference, visibly emotional. "I've dreamed about this moment since I was a kid playing in the streets. To score the winning goal in the championship... it's beyond anything I could have imagined."</p>
            
            <p>The team's journey to the championship has been nothing short of remarkable. After finishing near the bottom of the league last season, they underwent a major restructuring under new coach Sarah Williams, who implemented a distinctive playing style that prioritized teamwork over individual star power.</p>
            
            <p>"We don't have the budget of the bigger teams, so we had to be smarter," explained Williams. "We focused on building a cohesive unit where everyone understands their role and works for each other. Today proved that heart and teamwork can overcome even the most talented opponents."</p>
            
            <p>The victory sparked wild celebrations in the team's home city, with thousands of fans flooding the streets in an impromptu parade that continued well into the night. Many of the celebrating fans had never seen their team win a major trophy in their lifetime.</p>
            
            <p>Team captain Michael Chen, who has been with the club for 15 years through multiple relegation battles and near-bankruptcies, described the win as "vindication for everyone who stuck with us through the dark times."</p>
            
            <p>The championship victory also secures the team a spot in international competition next season, bringing additional revenue and exposure that could help establish them as a regular contender in years to come.</p>
        `
    },
    6: {
        id: 6,
        title: "Tech Giants Announce Collaboration",
        category: "Technology",
        date: "May 13, 2025",
        content: `
            <p>In a surprising move, three of the world's largest technology companies have announced a joint initiative to develop open standards for artificial intelligence safety.</p>
            
            <p>The collaboration, announced at a press conference yesterday, aims to create industry-wide protocols for testing, validating, and monitoring AI systems to ensure they operate safely and ethically as the technology becomes increasingly powerful and widespread.</p>
            
            <p>"This is about ensuring that as AI capabilities advance, the technology remains beneficial, safe, and under meaningful human control," said Elena Rodriguez, Chief AI Ethics Officer at one of the participating companies.</p>
            
            <p>The initiative will focus on developing shared benchmarks for evaluating AI systems, creating standardized safety testing procedures, and establishing best practices for deploying AI in sensitive domains such as healthcare, transportation, and critical infrastructure.</p>
            
            <p>Industry analysts have described the collaboration as unprecedented, given the typically competitive nature of these companies. "These firms have recognized that AI safety is a pre-competitive issue," explains Dr. James Chen, technology policy researcher. "No company benefits if AI development leads to harmful outcomes or public backlash."</p>
            
            <p>The consortium has committed $2 billion in funding over five years and will establish an independent oversight board comprising experts from academia, civil society organizations, and government to ensure the initiative serves the public interest.</p>
            
            <p>Regulatory bodies have welcomed the announcement but emphasized that industry self-regulation will complement, not replace, government oversight. "This is a positive step from industry leaders," said Commissioner Maria Thompson of the Technology Regulatory Commission. "But we will continue to develop appropriate regulatory frameworks to ensure AI development proceeds responsibly."</p>
            
            <p>The first technical standards from the initiative are expected to be published for public comment within six months.</p>
        `
    },
    7: {
        id: 7,
        title: "New Smartphone Features Unveiled",
        category: "Technology",
        date: "May 12, 2025",
        content: `
            <p>The latest generation of smartphones will feature groundbreaking technology that could transform how we interact with our devices, according to announcements made at yesterday's International Mobile Technology Conference.</p>
            
            <p>Among the most significant innovations is a new display technology that can dynamically switch between traditional flat screen mode and a textured surface that provides tactile feedback. This would allow users to "feel" virtual objects and textures, potentially revolutionizing mobile gaming, accessibility features for visually impaired users, and digital art creation.</p>
            
            <p>"This represents the biggest leap in touch interface technology since the introduction of the capacitive touchscreen," said Dr. Hiroshi Tanaka, lead engineer on the project. "We're adding a completely new sensory dimension to digital interaction."</p>
            
            <p>Battery technology is also seeing significant advancement, with new devices featuring solid-state batteries that can charge to 80% capacity in under five minutes and offer up to 72 hours of regular use on a single charge.</p>
            
            <p>Privacy features are receiving major upgrades as well, with advanced on-device AI systems that can detect and block sophisticated phishing attempts and unauthorized data collection in real-time without sending user data to cloud servers.</p>
            
            <p>"We're moving toward a model where privacy protection happens proactively and locally on your device, rather than reactively in the cloud," explained privacy engineer Sarah Johnson.</p>
            
            <p>Camera systems continue to advance, with computational photography techniques now able to capture professional-quality images in extremely challenging lighting conditions. New depth-sensing capabilities also allow for more accurate augmented reality applications.</p>
            
            <p>The first devices featuring these technologies are expected to reach consumers in the fourth quarter of this year, though analysts note that supply chain constraints may initially limit availability in some markets.</p>
        `
    }
};

// Function to get URL parameters
function getUrlParameter(name) {
    name = name.replace(/[\[]/, '\\[').replace(/[\]]/, '\\]');
    const regex = new RegExp('[\\?&]' + name + '=([^&#]*)');
    const results = regex.exec(location.search);
    return results === null ? '' : decodeURIComponent(results[1].replace(/\+/g, ' '));
}

// Function to load news details
function loadNewsDetails() {
    const newsId = getUrlParameter('id');
    const newsContentElement = document.getElementById('news-content');
    
    if (newsId && newsData[newsId]) {
        const article = newsData[newsId];
        
        // Create article HTML
        const articleHTML = `
            <h1>${article.title}</h1>
            <div class="meta">
                <span class="category">${article.category}</span>
                <span class="date">${article.date}</span>
            </div>
            <div class="featured-image">
                <img src="${article.image}" alt="${article.title}">
            </div>
            <div class="content">
                ${article.content}
            </div>
        `;
        
        // Update page title
        document.title = article.title + ' - News Portal';
        
        // Update content
        newsContentElement.innerHTML = articleHTML;
    } else if (newsContentElement) {
        // Handle case where article doesn't exist
        newsContentElement.innerHTML = `
            <div class="error-message">
                <h2>Article Not Found</h2>
                <p>Sorry, the article you're looking for doesn't exist or has been removed.</p>
                <a href="index.html" class="read-more">Return to Home</a>
            </div>
        `;
    }
}

// Add event listeners to all "Read More" buttons
document.addEventListener('DOMContentLoaded', function() {
    // Check if we're on the details page
    if (window.location.href.includes('news-details.html')) {
        loadNewsDetails();
    }
    
    // Add click event to all read more buttons
    const readMoreButtons = document.querySelectorAll('.read-more');
    readMoreButtons.forEach(button => {
        button.addEventListener('click', function() {
            const articleId = this.getAttribute('data-id');
            window.location.href = `news-details.html?id=${articleId}`;
        });
    });
});